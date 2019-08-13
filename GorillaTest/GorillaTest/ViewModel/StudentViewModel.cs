using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using GorillaTest.Model;

namespace GorillaTest.ViewModel
{
    public class StudentViewModel : INotifyPropertyChanged
    {
        #region properties
        private StudentModel _CurrentStudend = new StudentModel();
        public StudentModel CurrentStudend
        {
            get
            {
                return _CurrentStudend;
            }
            set
            {
                _CurrentStudend = value;
                OnPropertyChanged("CurrentStudent");
            }
        }

        private ObservableCollection<StudentModel> _sourceData { get; set; }

        public ObservableCollection<StudentModel> sourceData
        {
            get
            {
                return _sourceData;
            }
            set
            {
                _sourceData = value;
            }
        }
        #endregion

        #region Singlenton
        private static StudentViewModel instance = null;

        private StudentViewModel ()
        {
            sourceData = StudentModel.GetMenu();
        }
        public static StudentViewModel GetInstance()
        {
            if (instance == null)
            {
                instance = new StudentViewModel();
            }
            return instance;
        }

        public static void DeleteInstance()
        {
            if (instance != null)
            {
                instance = null;
            }
        }

        #endregion


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
