using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
