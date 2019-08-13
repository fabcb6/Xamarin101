using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using GorillaTest.Model;
using GorillaTest.View;
using Xamarin.Forms;

namespace GorillaTest.ViewModel
{
    public class MenuViewModel :INotifyPropertyChanged
    {

        private ObservableCollection<MenuModel> _sourceData { get; set; }

        public ObservableCollection<MenuModel> sourceData {
            get
            {
                return _sourceData;
            }
            set
            {
                _sourceData = value;
            }
        }

        public ICommand SelectMenuCommand { get; set; }

        public void SelectMenu (int id)
        {
            switch (id)
            {
                // Formulario
                case 1:
                    ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new ContactView());
                    break;
                // Students
                case 2:
                    ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new StudentView());
                    break;
                default:
                    break;
            }
        }

        public MenuViewModel()
        {
            sourceData = MenuModel.GetMenu();
            SelectMenuCommand = new Command<int>(SelectMenu);
        }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (propertyName != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
