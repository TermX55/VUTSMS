using System;
using System.ComponentModel;
using System.Reflection;

namespace VUT_Stock_Management_System.ViewModels
{
    public class ViewVUTSMSShellViewModel //: INotifyPropertyChanged
    {
        #region Properties & Attributes

        #region Properties

        /// <summary>
        /// The user currently logged in
        /// </summary>
        public string LoggedInUser
        {
            get { return _loggedInUser; }
            set { _loggedInUser = value; }
        }
        private string _loggedInUser;

        /// <summary>
        /// The application database server name
        /// </summary>
        public string ServerName
        {
            get { return _serverName; }
            set { _serverName = value; }
        }
        private string _serverName;

        /// <summary>
        /// The application database name
        /// </summary>
        public string DataBaseName
        {
            get { return _dataBaseName; }
            set { _dataBaseName = value; }
        }
        private string _dataBaseName;
        
        /// <summary>
        /// The IOBM published version
        /// </summary>
        public string ApplicationVersion
        {
            get { return _applicationVersion; }
            set { _applicationVersion = value; }
        }
        private string _applicationVersion;

        #endregion

        #endregion

        #region Methods

        //public event PropertyChangedEventHandler PropertyChanged;

        public ViewVUTSMSShellViewModel()
        {
            InitializeView();
        }

        public void InitializeView()
        {
            LoggedInUser = "Not Logged In";
            ServerName = "";
            DataBaseName = "VUT-SMS";
            ApplicationVersion = Convert.ToString(Assembly.GetEntryAssembly().GetName().Version);

        }

        #endregion
    }
}
