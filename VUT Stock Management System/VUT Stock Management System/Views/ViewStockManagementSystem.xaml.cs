using System.Windows.Controls;
using VUT_Stock_Management_System.ViewModels;

namespace VUT_Stock_Management_System.Views
{
    /// <summary>
    /// Interaction logic for ViewStockManagementSystem.xaml
    /// </summary>
    public partial class ViewStockManagementSystem : UserControl
    {
        public ViewStockManagementSystem()
        {
            InitializeComponent();
            this.DataContext = new ViewStockManagementSystemViewModel();
        }
    }
}
