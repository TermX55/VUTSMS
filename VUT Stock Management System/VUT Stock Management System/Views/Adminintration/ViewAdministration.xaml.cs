using System.Windows.Controls;
using VUT_Stock_Management_System.ViewModels;

namespace VUT_Stock_Management_System.Views.Adminintration
{
    /// <summary>
    /// Interaction logic for ViewAdministration.xaml
    /// </summary>
    public partial class ViewAdministration : UserControl
    {
        public ViewAdministration()
        {
            InitializeComponent();
            this.DataContext = new ViewAdministrationViewModel();
        }
    }
}
