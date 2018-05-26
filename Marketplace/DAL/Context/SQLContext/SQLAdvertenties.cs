using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Models;

namespace DAL.Context.SQLContext
{
    public class SQLAdvertenties : IAdvertenties
    {
        public List<Advertentie> GetAllAdvertenties()
        {
            List<Advertentie> advertentieslist = new List<Advertentie>();
            Connection c = new Connection();
            SqlConnection conn = c.conn();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Advertenties",conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            foreach(DataRow i in dt.Rows)
            {
                Advertentie a = new Advertentie(i.Field<int>(0), i.Field<int>(1), i.Field<decimal>(2), i.Field<decimal>(3), i.Field<string>(4), i.Field<DateTime>(5), i.Field<string>(6));
                advertentieslist.Add(a);
                
            }
            return advertentieslist;
            
        }
    }
}
