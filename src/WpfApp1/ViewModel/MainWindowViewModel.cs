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
            _changeNameCommand = new DelegateCommand(OnChangeName, CanChangeName);
            _relayCommand = new RelayCommand(OnChangeName, CanChangeName);
        }

        /*
        public string HelloText { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        */

        private readonly DelegateCommand _changeNameCommand;
        private readonly ICommand _relayCommand;

        public ICommand ChangeNameCommand => _changeNameCommand;

        public ICommand RelayCommand => _relayCommand;
        private void OnChangeName(object commandParameter)
        {
            HelloText = "Walter";
        }

        private bool CanChangeName(object commandParameter)
        {
            return HelloText != "Walter";
        }

        private string _helloText;
        public string HelloText
        {
            get => _helloText;
            set => SetProperty(ref _helloText, value);
        }


    }
}
