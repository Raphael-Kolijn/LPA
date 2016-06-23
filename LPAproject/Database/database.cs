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

        // SLuit de connectie
        public static void CloseConnection()
        {
            try
            { m_conn.Close(); }
            catch (Exception ex)
            { Console.WriteLine("Connection failed: " + ex.Message); }
        }

        /// Haalt het command-object op waarmee queries uitgevoerd kunnen worden.
        public static OracleCommand Command { get { return m_command; } }


        // Methode om te testen/verwijder op tijd
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

        // Sla een huurder op in de database
        public static bool insertHuurder(string naam, string email)
        {
            bool ok = false;
            try
            {
                OpenConnection();
                m_command = new OracleCommand();
                m_command.Connection = m_conn;
                m_command.CommandText = "INSERT INTO HUURDER (Naam, EmailAdres) VALUES (:naam, :emailAdres)";
                m_command.Parameters.Add("naam", OracleDbType.Varchar2).Value = naam;
                m_command.Parameters.Add("emailAdres", OracleDbType.Varchar2).Value = email;
                m_command.ExecuteNonQuery();

            }
            catch (OracleException ex)
            {
                database.CloseConnection();
                Console.WriteLine(ex.Message);
            }
            return ok;
        }

        // Sla een contract op in de database. ONGELDIGE VALUE: EINDDATUM. INSERT INTO HUURDER (Huurder, Naam, ArtikelID, StartDatum, EindDatum) VALUES ('Test', 'TestWater', 1, 23-6-2016, 24-6-2016);
        // Het ContractID wordt aan de hand van een trigger in de database berekent.
        public static bool insertContract(string Huurder, string NaamVaarWater, int ArtikelID, DateTime StartDatum, DateTime EindDatum)
        {
            bool ok = false;
            try
            {
                OpenConnection();
                m_command = new OracleCommand();
                m_command.Connection = m_conn;
                m_command.CommandText = "INSERT INTO HUURDER (Huurder, Naam, ArtikelID, StartDatum, EindDatum) VALUES (:Huurder, :Naam, :ArtikelID, :StartDatum, :EindDatum)";
                m_command.Parameters.Add("Huurder", OracleDbType.Varchar2).Value = Huurder;
                m_command.Parameters.Add("Naam", OracleDbType.Varchar2).Value = NaamVaarWater;
                m_command.Parameters.Add("ArtikelID", OracleDbType.Int32).Value = ArtikelID;
                m_command.Parameters.Add("StartDatum", OracleDbType.Date).Value = StartDatum;
                m_command.Parameters.Add("EindDatum", OracleDbType.Date).Value = EindDatum;
                m_command.ExecuteNonQuery();

            }
            catch (OracleException ex)
            {
                database.CloseConnection();
                Console.WriteLine(ex.Message);
            }
            return ok;
        }

        // Het toevoegen van een meer of zee aan de database. 
        public static bool insertVaarwater(string Naam, string YorN)
        {
            bool ok = false;
            try
            {
                OpenConnection();
                m_command = new OracleCommand();
                m_command.Connection = m_conn;
                m_command.CommandText = "INSERT INTO VAARWATER (Naam, Meer) VALUES (:Naam, :Meer)";
                m_command.Parameters.Add("Naam", OracleDbType.Varchar2).Value = Naam;
                m_command.Parameters.Add("Meer", OracleDbType.Varchar2).Value = YorN;
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

