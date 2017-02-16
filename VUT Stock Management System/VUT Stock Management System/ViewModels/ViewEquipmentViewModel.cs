

using System.Collections.ObjectModel;
using System.Windows.Controls;
using VUT_Stock_Management_System.Views.Equipment;

namespace VUT_Stock_Management_System.ViewModels
{
    class ViewEquipmentViewModel
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

        public ViewEquipmentViewModel()
        {
            InitialiseStockManagementSystemView();
        }

        /// <summary>
        /// Initialise all the view dependencies
        /// </summary>
        private void InitialiseStockManagementSystemView()
        {
            TabCollection = new ObservableCollection<TabItem>();

            TabCollection.Add(new TabItem() { Header = "Add Equipment" });
            TabCollection.Add(new TabItem() { Header = "Update/Remove Equipment" });

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
                case "Add Equipment":
                    if (tabItem.Content == null)
                        SelectedTab.Content = new ViewAddEquipment();
                    break;
                case "Update/Remove Equipment":
                    if (tabItem.Content == null)
                        SelectedTab.Content = new ViewUpdateRemoveEquipment();
                    break;

            }

            _selectedTabIndex = tabItem.TabIndex;
        }

        #endregion

    }
}
