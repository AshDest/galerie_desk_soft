using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalerieSoft.Configs
{
    public class Connection : INotifyPropertyChanged, IDataErrorInfo
    {
        private string _server = "";
        private string _database = "";
        private string _user = "";
        private string _password = "";

        private List<Connection> listDatabase = new List<Connection>();
        private Dictionary<string, string> _errorInfo;

        public event PropertyChangedEventHandler PropertyChanged;

        public Connection()
        {
            _errorInfo = new Dictionary<string, string>();
        }

        public Connection(string server, string db, string user, string pwd)
        {
            _errorInfo = _errorInfo = new Dictionary<string, string>();
            this._server = server;
            this._database = db;
            this._user = user;
            this._password = pwd;
        }

        private void ValidateProperty(string propertyName, object value)
        {
            var name = value as string;
            if ((name.Equals("")))
            {
                SetError(propertyName, "Ce champs ne peut pas être vide.");
            }
            else SetError(propertyName, string.Empty);
        }

        private void SetError(string propertyName, string error)
        {
            _errorInfo.Remove(propertyName);
            if (!(error.Equals("")))
                _errorInfo.Add(propertyName, error);
        }

        protected void RaisePropertyChanged(string propertyName, object obj)
        {
            if (this.PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            ValidateProperty(propertyName, obj);
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    RaisePropertyChanged("Password", value);
                }
            }
        }

        public string User
        {
            get { return _user; }
            set
            {
                if (_user != value)
                {
                    _user = value;
                    RaisePropertyChanged("User", value);
                }
            }
        }

        public string Database
        {
            get { return _database; }
            set
            {
                if (_database != value)
                {
                    _database = value;
                    RaisePropertyChanged("Database", value);
                }
            }
        }

        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged("Server", value);
                }
            }
        }

        public string Error
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string this[string columnName]
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
