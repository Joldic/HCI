// File:    AllergenRepository.cs
// Author:  joldic
// Created: 18 April 2022 13:02:42
// Purpose: Definition of Class AllergenRepository

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Model;
using HCI.Exception;

namespace Repository
{
   public class AllergenRepository
   {

        private const string NOT_FOUND_ERROR = "Account with {0}:{1} can not be found!";
        private readonly string _path;
        private readonly string _delimeter;
        private readonly string _dateTimeFormat;
        private uint _allergenMaxId;
        private uint _allergenDTOMaxId;
        private static string _projectPath = System.Reflection.Assembly.GetExecutingAssembly().Location
        .Split(new string[] { "bin" }, StringSplitOptions.None)[0];

        private FileStream temp;

        private String fileName;

        public AllergenRepository(string path, string delimeter, string dateTimeFormat)
        {
            _path = path;
            _delimeter = delimeter;
            _dateTimeFormat = dateTimeFormat;
            _allergenMaxId = GetMaxId(GetAll());
            _allergenDTOMaxId = GetMaxIdAllergenPatient(GetPatientsAllergens());
        }



        private uint GetMaxId(IEnumerable<Allergen> allergens)
        {
            return allergens.Count() == 0 ? 0 : allergens.Max(allergen => allergen.Id);
        }

        private uint GetMaxIdAllergenPatient(IEnumerable<PatientAllergenDTO> dto)
        {
            return dto.Count() == 0 ? 0 : dto.Max(dtos => dtos.Id);
        }


        public IEnumerable<Allergen> GetAll()
        {
            return File.ReadAllLines(_path)
                  .Select(ConvertCSVFormatToAllergen)
                  .ToList();
        }



        public Model.Allergen CreateNewAllergen(Model.Allergen allergen)
        {
            allergen.Id = ++_allergenMaxId;
            AppendLineToFile(_path, ConvertAllergenToCSVFormat(allergen));
            return allergen;
        }


        public PatientAllergenDTO AddPatientsAllergen(PatientAllergenDTO dto)
        {
            dto.Id = ++_allergenDTOMaxId;
            string pathDto = _projectPath + "\\Resources\\PatientAllergen.txt";
            AppendLineToFile(pathDto, ConvertPatientAllergenToCSVFormat(dto));
            return dto;
        }



        public Model.Allergen GetAllergen(uint id)
      {
            try
            {

                return GetAll().SingleOrDefault(allergen => allergen.Id == id);

            }
            catch (ArgumentException)
            {

                throw new NotFoundException(string.Format(NOT_FOUND_ERROR, "id", id));

            }
        }

        public IEnumerable<PatientAllergenDTO> GetPatientsAllergens()
        {
            string path_to_file = _projectPath + "\\Resources\\PatientAllergen.txt";
            return File.ReadAllLines(path_to_file)
                .Select(ConvertCSVFormatToPatientAllergen).ToList();
        }


        public Model.Allergen UpdateAllergen(Model.Allergen allergen)
      {
            string temp_file = _projectPath + "\\Resources\\tempALR.txt";
            string _file = _projectPath + "\\Resources\\allergen.txt";


            using (var sr = new StreamReader(_file))
            using (var sw = new StreamWriter(temp_file))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string lineToWrite = ConvertAllergenToCSVFormat(allergen);
                    Allergen tempApp = ConvertCSVFormatToAllergen(line);
                    if (allergen.Id != tempApp.Id)
                    {
                        sw.WriteLine(line);
                    }
                    else
                    {
                        sw.WriteLine(lineToWrite);
                    }
                    //sw.WriteLine(lineToWrite);
                }
            }
            File.Delete(_file);
            File.Move(temp_file, _file);



            return allergen;
        }
      



      public Boolean DeleteAllergen(uint id)
      {
            Boolean retVal = false;
            IEnumerable<Allergen> allergens = GetAll();

            allergens = allergens.Where(a => a.Id != id).ToList();

            string temp_file = _projectPath + "\\Resources\\tempAlr.txt";
            string allergen_file = _projectPath + "\\Resources\\allergen.txt";

            using (var sr = new StreamReader(allergen_file))
            using (var sw = new StreamWriter(temp_file))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Allergen allergen = ConvertCSVFormatToAllergen(line);
                    if (allergen.Id != id)
                    {
                        retVal = true;
                        sw.WriteLine(line);
                    }
                }
            }

            File.Delete(allergen_file);
            File.Move(temp_file, allergen_file);

            return retVal;
        }






        public Boolean DeletePatiensAllergen(uint id)
        {
            Boolean retval = false;

            string temp_file = _projectPath + "\\Resources\\tempPatAler.txt";
            string patientAllergens_file = _projectPath + "\\Resources\\PatientAllergen.txt";

            using (var sr = new StreamReader(patientAllergens_file))
            using (var sw = new StreamWriter(temp_file))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    PatientAllergenDTO patientAll = ConvertCSVFormatToPatientAllergen(line);
                    if (patientAll.Id != id)
                    {
                        retval = true;
                        sw.WriteLine(line);
                    }
                }
            }

            File.Delete(patientAllergens_file);
            File.Move(temp_file, patientAllergens_file);

            return retval;
        }



        private Allergen ConvertCSVFormatToAllergen(string allergenCSVFormat)
        {
            Allergen allergen = new Allergen();
            string[] tokens = allergenCSVFormat.Split(_delimeter.ToCharArray());

            uint Id = uint.Parse(tokens[0]);
            string Name = tokens[1];
           
            return new Allergen(
                Id,
                Name    
            );

        }

        private PatientAllergenDTO ConvertCSVFormatToPatientAllergen(string patientAllerenSCV)
        {
            PatientAllergenDTO patientAllergen = new PatientAllergenDTO();
            string[] tokens = patientAllerenSCV.Split(_delimeter.ToCharArray());
            uint Id = uint.Parse(tokens[0]);
            uint PatientId = uint.Parse(tokens[1]);
            uint AllergenId = uint.Parse(tokens[2]);
            string AllergenName = tokens[3];

            return new PatientAllergenDTO(
                Id,
                PatientId,
                AllergenId,
                AllergenName
                );
        }


        private string ConvertPatientAllergenToCSVFormat(PatientAllergenDTO patientAllergenDTO)
        {
            return string.Join(_delimeter,
                patientAllergenDTO.Id,
                patientAllergenDTO.PatientId,
                patientAllergenDTO.AllergenId,
                patientAllergenDTO.AllergenName
                );

        }

        private string ConvertAllergenToCSVFormat(Allergen allergen)
        {
            return string.Join(_delimeter,
                allergen.Id, 
                allergen.Name
            );

        }

        private void AppendLineToFile(string path, string line)
        {
            File.AppendAllText(path, line + Environment.NewLine);
        }

    }
}