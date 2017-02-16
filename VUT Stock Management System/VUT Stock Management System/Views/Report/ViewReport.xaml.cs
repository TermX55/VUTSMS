using System.Windows.Controls;
using VUT_Stock_Management_System.ViewModels;

namespace VUT_Stock_Management_System.Views.Report
{
    /// <summary>
    /// Interaction logic for ViewReport.xaml
    /// </summary>
    public partial class ViewReport : UserControl
    {
        public ViewReport()
        {
            InitializeComponent();
            this.DataContext = new ViewReportViewModel();
        }
    }
}
