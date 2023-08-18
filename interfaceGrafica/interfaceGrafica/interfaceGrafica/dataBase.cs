using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace interfaceGrafica
{
    internal class dataBase
    {
        private static SQLiteConnection connection;

        private static SQLiteConnection DataBaseConnect()
        {
            string dataSource = "DataSource=C:\\Users\\PC Gamer Derick\\Desktop\\Projetos GIT\\Estudos-BNE\\interfaceGrafica\\interfaceGrafica\\dataBase\\bd_testapp";

            connection = new SQLiteConnection(dataSource);
            connection.Open();
            return connection;
        }

        public static DataTable GenericSearch(string sqlCommand)
        {
            SQLiteDataAdapter adapter = null;
            DataTable dataTable = new DataTable();

            try
            {
                // "using" Engloba todo o conteúdo dentro da conexão, como se fosse um "container"
                using (var comando = DataBaseConnect().CreateCommand())
                {
                    comando.CommandText = sqlCommand;
                    adapter = new SQLiteDataAdapter(comando.CommandText, DataBaseConnect());
                    adapter.Fill(dataTable);
                    DataBaseConnect().Close();
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
