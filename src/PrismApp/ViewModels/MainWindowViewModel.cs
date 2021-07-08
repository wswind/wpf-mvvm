using Prism.Commands;
using Prism.Mvvm;

namespace PrismApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            ChangeTextCommand1 = new DelegateCommand(HelloAgain);
            ChangeTextCommand2 = new DelegateCommand(ChangeText, CanChangeText);
        }

        public DelegateCommand ChangeTextCommand1 { get; private set; }
        public DelegateCommand ChangeTextCommand2 { get; private set; }


        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        private void HelloAgain()
        {
            HelloText = "Hello Again WPF MVVM";
        }

        public void ChangeText()
        {
            HelloText = "changed";
        }

        bool CanChangeText()
        {
            return  HelloText != "changed";
        }


        private string _helloText = "Hello WPF MVVM";
        public string HelloText
        {
            get { return _helloText; }
            set 
            { 
                SetProperty(ref _helloText, value);
                ChangeTextCommand2.RaiseCanExecuteChanged();
            }
        }
    }
}
