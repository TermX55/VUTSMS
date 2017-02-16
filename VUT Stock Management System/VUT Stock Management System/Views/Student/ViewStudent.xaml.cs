using System.Windows.Controls;
using VUT_Stock_Management_System.ViewModels;

namespace VUT_Stock_Management_System.Views.Student
{
    /// <summary>
    /// Interaction logic for ViewStudent.xaml
    /// </summary>
    public partial class ViewStudent : UserControl
    {
        public ViewStudent()
        {
            InitializeComponent();
            this.DataContext = new ViewStudentViewModel();
        }
    }
}
