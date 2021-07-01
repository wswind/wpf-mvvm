using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1.ViewModel
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            HelloText = "Hello WPF MVVM";
        }
        public string HelloText { get; set; }
    }
}
