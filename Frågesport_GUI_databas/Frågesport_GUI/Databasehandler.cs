using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sqlite;

namespace Frågesport_GUI
{
    class Databasehandler
    {
        private string dbName = "databas.db";
        private string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

    }

    public string GetPathAndDbName()
    {
        return Path.Combine(docPath, dbName);
    }

    public List<Kort> GetKort()
    {
        List<Kort> kort = new List<Kort>();

        using (SqliteConnection db = new SqliteConnection($"Filename={GetPathAndDbName}"))
        {
            db.Open();
        } 
          
    }
}
