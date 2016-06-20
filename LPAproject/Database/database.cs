using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace LPAproject
{
    public static class database
    {
        static OracleConnection m_conn;
        static OracleCommand m_command;
        static string connectionString = "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS=(PROTOCOL=TCP)(HOST=192.168.15.50)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=fhictora)));User ID=dbi342562;PASSWORD=nintendo1;";

        // Open de verbinding met de database
        public static bool OpenConnection()
        {
            bool returnvalue = false;
            m_conn = new OracleConnection();
            try
            {
                m_conn.ConnectionString = connectionString;
                m_conn.Open();
                // Controleer of de verbinding niet al open is
                if (m_conn.State != System.Data.ConnectionState.Open)
                { return true; }
            }
            catch (Exception ex) { Console.WriteLine("Connection failed: " + ex.Message); }
            return returnvalue;
        }

        public static void CloseConnection()
        {
            try
            { m_conn.Close(); }
            catch (Exception ex)
            { Console.WriteLine("Connection failed: " + ex.Message); }
        }

        /// Haalt het command-object op waarmee queries uitgevoerd kunnen worden.
        public static OracleCommand Command { get { return m_command; } }

        public static bool postToBlog(string postText, string disciplineCat, string platformCat)
        {
            string result = "no";
            bool ok = false;

            int AutoID = 0;
            try
            {
                OpenConnection();
                m_command = new OracleCommand();
                m_command.Connection = m_conn;
                m_command.CommandText = "SELECT COUNT(BLOGID) from BLOG";
                m_command.ExecuteNonQuery();
                using (OracleDataReader _Reader = database.Command.ExecuteReader())
                {
                    while (_Reader.Read())
                    {
                        AutoID = Convert.ToInt32(_Reader["COUNT(BLOGID)"]) + 1;
                    }
                }


                m_command.CommandText = "INSERT INTO BLOG (BlogID, PostText, DisciplineCat, PlatformCat) VALUES (:BlogID, :PostText, :DisciplineCat, :PlatformCat)";
                m_command.Parameters.Add("BlogID", OracleDbType.Int32).Value = AutoID;
                m_command.Parameters.Add("PostText", OracleDbType.Varchar2).Value = postText;
                m_command.Parameters.Add("DisciplineCat", OracleDbType.Varchar2).Value = disciplineCat;
                m_command.Parameters.Add("PlatformCat", OracleDbType.Varchar2).Value = platformCat;
                m_command.ExecuteNonQuery();

            }
            catch (OracleException ex)
            {
                database.CloseConnection();
                Console.WriteLine(ex.Message);
            }
            return ok;
        }

    }


}

