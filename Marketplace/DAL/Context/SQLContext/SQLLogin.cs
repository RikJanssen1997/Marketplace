using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context.SQLContext
{
    public class SQLLogin: Interfaces.ILogin
    {
        public Klant GetKlant(string gebruikersnaam, string wachtwoord)
        {
            Connection c = new Connection();
            SqlConnection conn = c.conn();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Gebruiker INNER JOIN Klant ON Gebruiker.ID = Klant.GebruikersID WHERE Gebruikersnaam = @Name AND Wachtwoord = @Password", conn);
            cmd.Parameters.AddWithValue("@Name", gebruikersnaam);
            cmd.Parameters.AddWithValue("@Password", gebruikersnaam);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                Klant k = new Klant(dr.Field<int>(0), dr.Field<string>(1), dr.Field<string>(2), dr.Field<int>(3), dr.Field<string>(5), dr.Field<string>(6), dr.Field<string>(7), dr.Field<string>(10), dr.Field<string>(8), dr.Field<string>(9), dr.Field<string>(11));
                return k;
            }
            else return null;
            
        }
        public Beheerder GetAdmin( string gebruikersnaam, string wachtwoord)
        {
            Connection c = new Connection();
            SqlConnection conn = c.conn();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Gebruiker INNER JOIN Beheerder ON Gebruiker.ID = Beheerder.GebruikersID Where Gebruikersnaam = @Name AND Wachtwoord = @Password", conn);
            cmd.Parameters.AddWithValue("@Name", gebruikersnaam);
            cmd.Parameters.AddWithValue("@Password", gebruikersnaam);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                Beheerder b = new Beheerder(dr.Field<int>(0), dr.Field<string>(1), dr.Field<string>(2), dr.Field<int>(3));
                return b;
            }
            else return null;

        }

        

        
    }
}
