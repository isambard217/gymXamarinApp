using System;
using System.IO;
using SQLite;
using WeActiveApp.iOS.Persistence;
using WeActiveApp.Persistence;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDb))]

namespace WeActiveApp.iOS.Persistence {
    
    public class SQLiteDb : ISQLiteDb {
        
        public SQLiteDb() {
            
        }

        public SQLiteAsyncConnection GetConnection() {

            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

			var path = Path.Combine(documentPath, "MySQLite.db3");

			return new SQLiteAsyncConnection(path);

		}
    }
}
