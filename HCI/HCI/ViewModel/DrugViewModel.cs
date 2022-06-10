using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI.ViewModel
{
    public class DrugViewModel : ViewModelBase
    {
        private readonly Drug _drug;
        public uint Id => _drug.Id;
        public string Name => _drug.Name;

        public uint Weight => _drug.Weight;

        public string Category => _drug.Category;

        public uint Quantity => _drug.Quantity;

        public DrugViewModel(Drug drug)
        {
            _drug = drug;
        }
    }
}
