using System.Collections.ObjectModel;
using System.Windows.Controls;
using VUT_Stock_Management_System.Views.Booking;

namespace VUT_Stock_Management_System.ViewModels
{
    public class ViewBookingViewModel
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

        public ViewBookingViewModel()
        {
            InitialiseStockManagementSystemView();
        }

        /// <summary>
        /// Initialise all the view dependencies
        /// </summary>
        private void InitialiseStockManagementSystemView()
        {
            TabCollection = new ObservableCollection<TabItem>();

            TabCollection.Add(new TabItem() { Header = "New Booking" });
            TabCollection.Add(new TabItem() { Header = "Return Booking" });
            
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
                case "New Booking":
                    if (tabItem.Content == null)
                        SelectedTab.Content = new ViewNewBooking();
                    break;
                case "Return Booking":
                    if (tabItem.Content == null)
                        SelectedTab.Content = new ViewReturnBooking();
                    break;
                
            }

            _selectedTabIndex = tabItem.TabIndex;
        }

        #endregion

    }
}
