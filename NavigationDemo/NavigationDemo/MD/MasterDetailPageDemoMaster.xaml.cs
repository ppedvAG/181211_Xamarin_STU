using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationDemo.MD
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPageDemoMaster : ContentPage
    {
        public ListView ListView;

        public MasterDetailPageDemoMaster()
        {
            InitializeComponent();

            BindingContext = new MasterDetailPageDemoMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetailPageDemoMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailPageDemoMenuItem> MenuItems { get; set; }
            
            public MasterDetailPageDemoMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetailPageDemoMenuItem>(new[]
                {
                    new MasterDetailPageDemoMenuItem(typeof(MasterDetailPageDemoDetail)) { Id = 0, Title = "Page 1" },
                    new MasterDetailPageDemoMenuItem(typeof(MasterDetailPageDemoDetail)) { Id = 1, Title = "Page 2" },
                    new MasterDetailPageDemoMenuItem(typeof(MasterDetailPageDemoDetail)) { Id = 2, Title = "Page 3" },
                    new MasterDetailPageDemoMenuItem(typeof(MainPage)) { Id = 3, Title = "MainPage" },
                    new MasterDetailPageDemoMenuItem(typeof(TabbedPageDemo)) { Id = 4, Title = "TabbedPageDemo" },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}