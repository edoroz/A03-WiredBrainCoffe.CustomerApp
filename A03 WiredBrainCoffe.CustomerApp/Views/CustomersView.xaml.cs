using System.Windows;
using System.Windows.Controls;

namespace A03_WiredBrainCoffe.CustomerApp.Views
{
    /// <summary>
    /// Interaction logic for CustomersView.xaml
    /// </summary>
    public partial class CustomersView:UserControl
    {
        public CustomersView()
        {
            InitializeComponent();
        }
        private void ButtonMoveNavigation_Click(object sender, RoutedEventArgs e)
        {
            var column = (int) CustomerListGrid.GetValue(Grid.ColumnProperty);
            var newColumn = column == 0
                ? 2
                : 0;
            CustomerListGrid.SetValue(Grid.ColumnProperty, newColumn);
        }
    }
}
