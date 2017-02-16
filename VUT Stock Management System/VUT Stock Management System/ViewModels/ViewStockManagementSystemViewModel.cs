using System.Collections.ObjectModel;
using System.Windows.Controls;
using VUT_Stock_Management_System.Views.Adminintration;
using VUT_Stock_Management_System.Views.Booking;
using VUT_Stock_Management_System.Views.Equipment;
using VUT_Stock_Management_System.Views.Report;
using VUT_Stock_Management_System.Views.Student;

namespace VUT_Stock_Management_System.ViewModels
{
    public class ViewStockManagementSystemViewModel
    {
        #region Properties and Attributes
        
        private int _selectedTabIndex = 0;

        #region Properties

        /// <summary>
        /// The selected tab item
        /// </summary>
        public TabItem SelectedTab
        {
            get { return _selectedTab; }
            set { _selectedTab = value; SetTabContent(value); }
        }
        private TabItem _selectedTab = null;

        /// <summary>
        /// The collection of tab pages for the tab control menu
        /// </summary>
        public ObservableCollection<TabItem> TabCollection
        {
            get { return _tabCollection; }
            set { _tabCollection = value; }
        }
        private ObservableCollection<TabItem> _tabCollection = null;

        #endregion

        #endregion

        #region Methods

        public ViewStockManagementSystemViewModel()
        {
            InitialiseStockManagementSystemView();
        }

        /// <summary>
        /// Initialise all the view dependencies
        /// </summary>
        private void InitialiseStockManagementSystemView()
        {
            TabCollection = new ObservableCollection<TabItem>();

            TabCollection.Add(new TabItem() { Header = "Bookings" });
            TabCollection.Add(new TabItem() { Header = "Equipment" });
            TabCollection.Add(new TabItem() { Header = "Students" });
            TabCollection.Add(new TabItem() { Header = "Reports" });
            TabCollection.Add(new TabItem() { Header = "Administration" });

            //Set the selected tab value
            SelectedTab = TabCollection[0];
        }

        /// <summary>
        /// When the user select a menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetTabContent(TabItem tabItem)
        {
            
            switch (tabItem.Header.ToString())
            {
                case "Bookings":
                    if (tabItem.Content == null)
                        SelectedTab.Content = new ViewBooking();
                    break;
                case "Equipment":
                    if (tabItem.Content == null)
                        SelectedTab.Content = new ViewEquipment();
                    break;
                case "Students":
                    if (tabItem.Content == null)
                        SelectedTab.Content = new ViewStudent();
                    break;
                case "Reports":
                    if (tabItem.Content == null)
                        SelectedTab.Content = new ViewReport();
                    break;
                case "Administration":
                    if (tabItem.Content == null)
                        SelectedTab.Content = new ViewAdministration();
                    break;
            }

            _selectedTabIndex = tabItem.TabIndex;
        }

        #endregion

    }
}
