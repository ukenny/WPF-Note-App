using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using SQLite;

namespace WPF_Note_App.Model
{
    public class Notebook: INotifyPropertyChanged
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

        private int _notebookId;
        [Indexed]
        public int NotebookId
        {
            get { return _notebookId; }
            set
            {
                if (value != this._notebookId)
                {
                    this._notebookId = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _noteTitle;

        public string NoteTitle
        {
            get { return _noteTitle; }
            set
            {
                if (value != this._noteTitle)
                {
                    this._noteTitle = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private DateTime _noteCreatedTime;

        public DateTime NoteCreatedTime
        {
            get { return _noteCreatedTime; }
            set
            {
                if (value != this._noteCreatedTime)
                {
                    this._noteCreatedTime = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private DateTime _noteLastUpdated;

        public DateTime NoteLastUpdated
        {
            get { return _noteLastUpdated; }
            set
            {
                if (value != this._noteLastUpdated)
                {
                    this._noteLastUpdated = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _noteFileLocation;

        public string NoteFileLocation
        {
            get { return _noteFileLocation; }
            set
            {
                if (value != this._noteFileLocation)
                {
                    this._noteFileLocation = value;
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
