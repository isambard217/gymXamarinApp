using System;
using SQLite;

namespace WeActiveApp.Persistence {
    
    public interface ISQLiteDb {

        SQLiteAsyncConnection GetConnection();
    }
}
