using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

namespace HelloASP.NET
{
    class MS_SQL_Person : iPersonDAO
    {
        private BindingList<Person> outSidelist = new BindingList<Person>();
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\vel\HelloASP.NET\HelloASP.NET\App_Data\MSData.mdf;Integrated Security=True");
        SqlCommand cmd;
        string qwery;

        public void create(Person p)
        {
            connect.Open();
            qwery = "insert dbo.PersonDB ( fname, lname, age) values('" + p.fname + "', '" + p.lname + "', '" + p.age + "'); SELECT * FROM dbo.PersonDB WHERE ID = @@IDENTITY ";
            cmd = new SqlCommand(qwery, connect);
            int d = cmd.ExecuteNonQuery();
            p.id = d;
            connect.Close();
        }

        public void delete(Person p)
        {
            connect.Open();
            qwery = "DELETE FROM dbo.PersonDB WHERE id=" + @p.id;
            cmd = new SqlCommand(qwery, connect);
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public BindingList<Person> read()
        {
            outSidelist.Clear();
            connect.Open();
            qwery = "Select * From dbo.PersonDB";
            cmd = new SqlCommand(qwery, connect);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                outSidelist.Add(new Person(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3)));
            }
            connect.Close();
            return outSidelist;
        }

        public void update(Person p)
        {
            connect.Open();
            qwery = @"UPDATE dbo.PersonDB SET fname='" + @p.fname + @"', lname='" + @p.lname + @"', age='" + @p.age + @"' WHERE id='" + @p.id + "';";
            cmd = new SqlCommand(qwery, connect);
            cmd.ExecuteNonQuery();
            connect.Close();
        }
    }
}
