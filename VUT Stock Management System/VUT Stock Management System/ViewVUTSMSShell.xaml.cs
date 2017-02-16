using System.Windows;
using VUT_Stock_Management_System.ViewModels;

namespace VUT_Stock_Management_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ViewVUTSMSShellViewModel();
        }
    }
}
