using PrismApp.ViewModels;
using System.Windows;

namespace PrismApp.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as MainWindowViewModel;
            vm.ChangeText(null);
        }
    }
}
