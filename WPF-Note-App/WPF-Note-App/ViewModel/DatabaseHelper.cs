using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SQLite;

namespace WPF_Note_App.ViewModel
{
    internal class DatabaseHelper
    {
        private static string dbFile = Path.Combine(Environment.CurrentDirectory, "notes.db3");

        public static bool Insert<T>(T item)
        {
            int insertionResult = 0;

            using (SQLiteConnection conn = new SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                insertionResult = conn.Insert(item);
            }

            return insertionResult != 0;
        }

        public static bool Update<T>(T item)
        {
            int updateResult = 0;

            using (SQLiteConnection conn = new SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                updateResult = conn.Update(item);
            }

            return updateResult != 0;
        }

        public static bool Delete<T>(T item)
        {
            int deleteResult = 0;

            using (SQLiteConnection conn = new SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                deleteResult = conn.Delete(item);
            }

            return deleteResult != 0;
        }
    }
}
