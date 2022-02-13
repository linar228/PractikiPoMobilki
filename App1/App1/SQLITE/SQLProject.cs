using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App1.SQLITE
{
    class SQLProject
    {
        SQLiteConnection db;
        
        public SQLProject(string dbPath)
        {
            db = new SQLiteConnection(dbPath);
            db.CreateTable<Project>();
        }


        public IEnumerable<Project> GetItems()
        {
            return db.Table<Project>().ToList();
        }


        public Project GetItem(int id)
        {
            return db.Get<Project>(id);
        }


        public int DeleteItem(int id)
        {
            return db.Delete<Project>(id);
        }

        public int SaveItem(Project item)
        {
            if (item.Id != 0)
            {
                db.Update(item);
                return item.Id;
            }
            else
            {
                return db.Insert(item);
            }
        }
    }
}
