using System.Windows;
using WpfApp1.ViewModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private readonly MainWindowViewModel _vm;

        public MainWindow()
        {
            DataContext = new MainWindowViewModel(); 
            InitializeComponent();
        }

        //private void btnTest_Click(object sender, RoutedEventArgs e)
        //{
        //    _vm.HelloText = "Hello Again WPF MVVM";
        //    //_vm.OnPropertyChanged(nameof(MainWindowViewModel.HelloText));
        //}
    }
}
