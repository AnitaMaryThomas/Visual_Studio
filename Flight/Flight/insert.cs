using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight
{
    internal class insert
    {
        public void insertdata(SqlConnection conn)
        {
        string cmdString = "select * from Customers";
        SqlCommand cmd = new SqlCommand(cmdString, conn);
        cmd.CommandText = "insert into Customers values(106,'Ammu', 'ammu@test.com', '6543219090')";
        int rowsAffected = cmd.ExecuteNonQuery();
        Console.WriteLine("Inserted rows : " + rowsAffected);
    }
            }
}
