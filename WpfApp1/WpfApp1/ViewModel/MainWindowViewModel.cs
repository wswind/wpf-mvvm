using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WpfApp1.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            HelloText = "Hello WPF MVVM";
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        public string HelloText { get; set; }
    }
}
