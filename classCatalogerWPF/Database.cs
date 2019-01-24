using System.Data.SQLite;
using System.IO;

namespace classCatalogerWPF
{
    class Database
    {
        public SQLiteConnection myConnection;

        public Database()
        {
            myConnection = new SQLiteConnection("Data source=bookBase.sqlite3");

            //If the database does not currently exist, create it.
            if(!File.Exists("./bookBase.sqlite3"))
            {
                SQLiteConnection.CreateFile("bookBase.sqlite3");
            }
        }
    }
}
