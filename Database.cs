using System.Data.SqlClient;

namespace HiraKata_Kaizen {
    internal class Database {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=hirakata_kaizen;Integrated Security=True");

        public void openConnection() {
            if (con.State == System.Data.ConnectionState.Closed) {
                con.Open();
            }
        }
        public void closeConnection() {
            if (con.State == System.Data.ConnectionState.Open) {
                con.Close();
            }
        }

        public SqlConnection getConnection() {
            return con;
        }
    }
}
