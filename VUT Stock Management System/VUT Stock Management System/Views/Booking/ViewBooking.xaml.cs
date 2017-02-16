using System.Windows.Controls;
using VUT_Stock_Management_System.ViewModels;

namespace VUT_Stock_Management_System.Views.Booking
{
    /// <summary>
    /// Interaction logic for ViewBooking.xaml
    /// </summary>
    public partial class ViewBooking : UserControl
    {
        public ViewBooking()
        {
            InitializeComponent();
            this.DataContext = new ViewBookingViewModel();
        }
    }
}
