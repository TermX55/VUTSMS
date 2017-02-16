using System.Collections.ObjectModel;
using System.Windows.Controls;
using VUT_Stock_Management_System.Views.Adminintration;

namespace VUT_Stock_Management_System.ViewModels
{
    class ViewAdministrationViewModel
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

        public ViewAdministrationViewModel()
        {
            InitialiseStockManagementSystemView();
        }

        /// <summary>
        /// Initialise all the view dependencies
        /// </summary>
        private void InitialiseStockManagementSystemView()
        {
            TabCollection = new ObservableCollection<TabItem>();

            TabCollection.Add(new TabItem() { Header = "Groups" });
            TabCollection.Add(new TabItem() { Header = "Accounts" });

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
                case "Groups":
                    if (tabItem.Content == null)
                        SelectedTab.Content = new ViewGroup();
                    break;
                case "Accounts":
                    if (tabItem.Content == null)
                        SelectedTab.Content = new ViewAccount();
                    break;

            }

            _selectedTabIndex = tabItem.TabIndex;
        }

        #endregion

    }
}
