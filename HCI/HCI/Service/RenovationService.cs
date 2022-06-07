using Model;
using HCI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI.Service
{
    public class RenovationService
    {
        private readonly RenovationRepository _repo;

        public RenovationService(RenovationRepository repo)
        {
            _repo = repo;
        }
        public IEnumerable<RoomRenovationDTO> GetAllRenovation()
        {
            return _repo.GetAllRenovation();
        }

        public RoomRenovationDTO AddRenovation(RoomRenovationDTO dto)
        {
            if(!(DateTime.Compare(dto.Start, dto.End) < 0))
            {
                return null;
            }
            return _repo.AddRenovation(dto);
        }

     

    }
}
