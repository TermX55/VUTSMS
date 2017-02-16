using System.Windows.Controls;
using VUT_Stock_Management_System.ViewModels;

namespace VUT_Stock_Management_System.Views.Equipment
{
    /// <summary>
    /// Interaction logic for ViewEquipment.xaml
    /// </summary>
    public partial class ViewEquipment : UserControl
    {
        public ViewEquipment()
        {
            InitializeComponent();
            this.DataContext = new ViewEquipmentViewModel();
        }
    }
}
