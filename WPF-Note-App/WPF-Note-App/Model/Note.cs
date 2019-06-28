using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using SQLite;

namespace WPF_Note_App.Model
{
    public class Note: INotifyPropertyChanged
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

        private int _userId;
        [Indexed]
        public int UserId
        {
            get { return _userId; }
            set
            {
                if (value != this._userId)
                {
                    this._userId = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _noteName;

        public string NoteName
        {
            get { return _noteName; }
            set
            {
                if (value != this._noteName)
                {
                    this._noteName = value;
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
