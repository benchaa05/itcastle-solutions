using System.Windows;
using GestionCommerciale.DomainModel.ClassesClients;

namespace GestionCommerciale.Dialogs.Sale
{
    /// <summary>
    /// Interaction logic for TVADialog.xaml
    /// </summary>
    public partial class SaleDialog : Window
    {
        public SaleDialog()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            OrderClient sales = new OrderClient();
            dgSales.ItemsSource = sales.GetOrder();
            
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
