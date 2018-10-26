using System;
using SQLite;
using WeActiveApp.Persistence;
using Xamarin.Forms;

namespace WeActiveApp.Data {


    public class Setting {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

    }
    
    public class Database {

        SQLiteAsyncConnection database;

        public Database() {

            // This is the gateway to the database.
            // It is the same as DBContext in entity framework
            var connection = DependencyService.Get<ISQLiteDb>().GetConnection();

            // Create tables 

            connection.CreateTableAsync<Setting>();

        }
    }
}
