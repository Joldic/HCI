using HCI.ViewModel;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI.Commands
{
    public class SubmitDrugCommand : CommandBase
    {
        private readonly Drug _drug;
        private readonly AddDrugViewModel _addDrugViewModel;
        public override void Execute(object parameter)
        {
            Drug drug = new Drug(_addDrugViewModel.Name, _addDrugViewModel.Weight, _addDrugViewModel.Category,
                _addDrugViewModel.Quantity);

            //ovde treba da se pozove kontroler i  da se doda taj lek u bazu
        }

        public SubmitDrugCommand(AddDrugViewModel addDrugViewModel)
        {
           _addDrugViewModel = addDrugViewModel;


        }
    }
}
