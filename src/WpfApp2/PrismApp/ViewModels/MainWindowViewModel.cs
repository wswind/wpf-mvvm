using Prism.Commands;
using Prism.Mvvm;

namespace PrismApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            ChangeTextCommand = new DelegateCommand<object>(ChangeText, CanChangeText);
        }

        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public void ChangeText(object parameter)
        {
            HelloText = "changed";
        }

        bool CanChangeText(object parameter)
        {
            return true;
        }



        public DelegateCommand<object> ChangeTextCommand { get; private set; }




        private string _helloText = "origin";
        public string HelloText
        {
            get { return _helloText; }
            set { SetProperty(ref _helloText, value); }
        }
    }
}
