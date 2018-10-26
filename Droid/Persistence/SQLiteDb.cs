using System;
using System.IO;
using SQLite;
using WeActiveApp.Droid.Persistence;
using WeActiveApp.Persistence;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDb))]

namespace WeActiveApp.Droid.Persistence {
    
    public class SQLiteDb : ISQLiteDb {
        
        public SQLiteDb() {

		}

        public SQLiteAsyncConnection GetConnection() {
			
			var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			var path = Path.Combine(documentsPath, "MySQLite.db3");

			return new SQLiteAsyncConnection(path);

		}
    }
}
