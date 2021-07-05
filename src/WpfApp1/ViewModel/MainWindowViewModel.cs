using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace WpfApp1.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            HelloText = "Hello WPF MVVM";
            _changeNameCommand = new DelegateCommand(OnChangeName, CanChangeName);
        }

        /*
        public string HelloText { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        */

        private readonly DelegateCommand _changeNameCommand;
        public ICommand ChangeNameCommand => _changeNameCommand;

      
        private void OnChangeName(object commandParameter)
        {
            HelloText = "Walter";
        }

        private bool CanChangeName(object commandParameter)
        {
            return HelloText != "Walter";
        }

        private string _helloText;
        public string HelloText { 
            get => _helloText;
            set => SetProperty(ref _helloText, value);
        }


    }
}
