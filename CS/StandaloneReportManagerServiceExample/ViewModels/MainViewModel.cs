using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandaloneReportManagerServiceExample.ViewModels {
    public class MainViewModel : ViewModelBase {
        public List<ItemViewModel> Items {
            get { return GetProperty(() => Items); }
            set { SetProperty(() => Items, value); }
        }

        public MainViewModel() {
            Items = new List<ItemViewModel>() {
                new ItemViewModel() { ID = 1, Name = "First" },
                new ItemViewModel() { ID = 2, Name = "Second" },
                new ItemViewModel() { ID = 3, Name = "Third" },
                new ItemViewModel() { ID = 4, Name = "Fourth" },
            };
        }
    }

    public class ItemViewModel : ViewModelBase {
        public string Name {
            get { return GetProperty(() => Name); }
            set { SetProperty(() => Name, value); }
        }
        public int ID {
            get { return GetProperty(() => ID); }
            set { SetProperty(() => ID, value); }
        }
    }
}
