// Tong Wang
using System.Windows;

namespace JoesFruitDrink
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VM vm = new VM();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }
        private void invoice_Click(object sender, RoutedEventArgs e)
        {
            vm.genInvoice();
        }
    }
}
