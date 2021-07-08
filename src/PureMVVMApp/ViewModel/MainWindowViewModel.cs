using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using WpfApp1.Command;

namespace WpfApp1.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            HelloText = "Hello WPF MVVM";
            //_changeNameCommand = new DelegateCommand(OnChangeName, CanChangeName);
            _relayCommand1 = new RelayCommand(HelloAgain);
            _relayCommand2 = new RelayCommand(ChangeName, CanChangeName);
        }

        private void HelloAgain(object obj)
        {
            HelloText = "Hello Again WPF MVVM";
        }

        /*
        public string HelloText { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        */

        //private readonly DelegateCommand _changeNameCommand;

        private readonly ICommand _relayCommand1;
        private readonly ICommand _relayCommand2;

        //public ICommand ChangeNameCommand => _changeNameCommand;

        public ICommand RelayCommand1 => _relayCommand1;
        public ICommand RelayCommand2 => _relayCommand2;
        private void ChangeName(object commandParameter)
        {
            HelloText = "changed";
        }

        private bool CanChangeName(object commandParameter)
        {
            return HelloText != "changed";
        }

        private string _helloText;
        public string HelloText
        {
            get => _helloText;
            set => SetProperty(ref _helloText, value);
        }


    }
}
