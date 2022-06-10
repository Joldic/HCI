using HCI.Commands;
using HCI.Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HCI.ViewModel
{
    public class DrugListingViewModel : ViewModelBase
    {
        public ICommand AddDrugCommand { get;  }
        public ICommand DeleteDrugCommand { get;  }
        private readonly ObservableCollection<DrugViewModel> _drugs;

        private DrugController _drugController;
        public ObservableCollection<DrugViewModel> Drugs => _drugs;
        public DrugListingViewModel()
        {
            _drugs = new ObservableCollection<DrugViewModel>();
            var app = Application.Current as App;
            _drugController = app.DrugController;

            AddDrugCommand = new NavigateCommand();

            _drugs.Add(new DrugViewModel(new Drug(1, "bromazepam", 1, "nervs", 1)));
            _drugs.Add(new DrugViewModel(new Drug(1, "lorazepam", 1, "nervs", 1)));
            _drugs.Add(new DrugViewModel(new Drug(1, "xanax", 1, "nervs", 1)));

        }



    }
}
