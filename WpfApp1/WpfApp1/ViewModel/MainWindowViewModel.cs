using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WpfApp1.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            HelloText = "Hello WPF MVVM";
        }

        /*
        public string HelloText { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        */

        private string _helloText;
        public string HelloText { 
            get => _helloText;
            set => SetProperty(ref _helloText, value);
        }


    }
}
