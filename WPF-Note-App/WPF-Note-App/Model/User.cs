using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using SQLite;

namespace WPF_Note_App.Model
{
    public class User : INotifyPropertyChanged
    {
        private int _id;
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get { return _id; }
            set
            {
                if (value != this._id)
                {
                    this._id = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _firstName;
        [MaxLength(50)]
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (value != this._firstName)
                {
                    this._firstName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _lastName;
        [MaxLength(50)]
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (value != this._lastName)
                {
                    this._lastName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _username;
        [Unique]
        public string Username
        {
            get { return _username; }
            set
            {
                
                if (value != this._username)
                {
                    this._username = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _userEmail;

        public string UserEmail
        {
            get { return _userEmail; }
            set
            {
                if (value != this._userEmail)
                {
                    this._userEmail = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                if (value != this._password)
                {
                    this._password = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
