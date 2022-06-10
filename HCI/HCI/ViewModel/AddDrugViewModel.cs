using HCI.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HCI.ViewModel
{
    public class AddDrugViewModel : ViewModelBase
    {
        private string _name;
        private uint _weight;
        private string _category;
        private uint _quantity;

        public RelayCommand SubmitCommand;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }

        public uint Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
                OnPropertyChanged(nameof(Weight));
            }
        }

        public uint Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }

        public void Executed_SubmitCommand(object obj)
        {
            //_drugController.add
        }

        //public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public AddDrugViewModel()
        {
            //SubmitCommand = new SubmitDrugCommand(this);
            CancelCommand = new CancelAddDrugCommand();
        }
    }
}
