using System.ComponentModel;
using System.Windows.Input;
using MVVMTest.Model;

namespace MVVMTest.ViewModel
{
    public class CheckBoxViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged RaisePropertyChanged(实现INotifyPropertyChanged)

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region firstCheckBox (INotifyPropertyChanged Property)(第一个CheckBox)

        private bool _firstCheckBox;

        public bool firstCheckBox
        {
            get { return _firstCheckBox; }
            set
            {
                if (_firstCheckBox != null && _firstCheckBox.Equals(value)) return;
                _firstCheckBox = value;
                if (_firstCheckBox)
                {
                    secondCheckBox = false;
                    thirdCheckBox = false;
                }
                RaisePropertyChanged("firstCheckBox");
            }
        }

        #endregion

        #region secondCheckBox (INotifyPropertyChanged Property)(第二个CheckBox)

        private bool _secondCheckBox;

        public bool secondCheckBox
        {
            get { return _secondCheckBox; }
            set
            {
                if (_secondCheckBox != null && _secondCheckBox.Equals(value)) return;
                _secondCheckBox = value;
                RaisePropertyChanged("secondCheckBox");
            }
        }

        #endregion

        #region thirdCheckBox (INotifyPropertyChanged Property)(第三个CheckBox)

        private bool _thirdCheckBox;

        public bool thirdCheckBox
        {
            get { return _thirdCheckBox; }
            set
            {
                if (_thirdCheckBox != null && _thirdCheckBox.Equals(value)) return;
                _thirdCheckBox = value;
                if (_thirdCheckBox)
                    secondCheckBox = true;
                RaisePropertyChanged("thirdCheckBox");
            }
        }

        #endregion

        #region CheckBoxCommand

        private RelayCommand _checkBoxCommand;

        public ICommand CheckBoxCommand
        {
            get
            {
                if (_checkBoxCommand == null)
                    _checkBoxCommand = new RelayCommand(param => SelectedAllCheckBox(param));
                return _checkBoxCommand;
            }
        }

        private void SelectedAllCheckBox(object param)
        {
            firstCheckBox = true;
            thirdCheckBox = true;
        }

        #endregion
    }
}