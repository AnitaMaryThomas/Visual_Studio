using System.Data;
using System.Data.SqlClient;
namespace Flight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string cs = "Data Source = ANITAMARYTHOMAS\\SQLEXPRESS; Initial Catalog = Flight_Management; Integrated Security = True; Pooling = False";
                SqlConnection conn = new SqlConnection(cs);
                conn.Open();


                //string cmdString = "select * from Customers";
                //SqlCommand cmd = new SqlCommand(cmdString, conn);
                //SqlDataReader dataReader = cmd.ExecuteReader();
                //Console.WriteLine("Name\t Email \t\t Mobile");
                //while (dataReader.Read())
                //{
                //    Console.WriteLine(dataReader["Customer_Nmae"] + "\t" + dataReader[2] + "\t" + dataReader["Customer_Mobile"]);
                //}
                //dataReader.Close();
                //cmd.CommandText = "select count(*) from Customers";
                //int count=(int)cmd.ExecuteScalar();
                //Console.WriteLine("Total no of Records: "+ count);

                //cmd.CommandText = "insert into Customers values(106,'Ammu', 'ammu@test.com', '6543219090')";
                //int rowsAffected=cmd.ExecuteNonQuery();
                //Console.WriteLine("Inserted rows: " + rowsAffected);

                //cmd.CommandText = "update Customers set Customer_Mobile='987654' where Customers_id=106";
                //int rowsAffected = cmd.ExecuteNonQuery();
                //Console.WriteLine("Updated rows: " + rowsAffected);

                //cmd.CommandText = "delete from Customers where Customer_id=6";
                //int rowsAffected = cmd.ExecuteNonQuery();
                //Console.WriteLine("Deleted rows: " + rowsAffected);

                //string qs = "select * from Customers;select * from Orders";
                //SqlDataAdapter dataAdapter = new SqlDataAdapter(qs, conn);
                //DataTable dt = new DataTable();
                //dataAdapter.Fill(dt);
                //foreach (DataRow dr in dt.Rows)
                //{
                //    Console.WriteLine(dr[0].ToString() + ", "+ dr[1].ToString()+", " + dr[3].ToString());

                //}

                //DataSet ds= new DataSet();
                //dataAdapter.Fill(ds);
                //foreach (DataRow row in ds.Tables[0].Rows)
                //{
                //    Console.WriteLine(row[0].ToString() + ", " + row[1].ToString());
                //}
                //foreach (DataRow row in ds.Tables[1].Rows)
                //{
                //    Console.WriteLine(row[0].ToString() + ", " + row[1].ToString());
                //}
                //SqlDataAdapter dataAdapter= new SqlDataAdapter("spGetCustomers", conn);
                //dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                //DataTable dt= new DataTable();
                //dataAdapter.Fill(dt);
                //foreach (DataRow dr in dt.Rows)
                //{
                //    Console.WriteLine(dr[0].ToString() + ", " + dr[1].ToString() + ", " + dr[2].ToString());
                //}

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "spGetCustomersById";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = conn; 

                SqlParameter sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@Id";
                sqlParameter.DbType = DbType.Int32;
                sqlParameter.Direction = ParameterDirection.Input;
                sqlParameter.Value = 101;

                sqlCommand.Parameters.Add(sqlParameter); 
                SqlDataReader dataReader = sqlCommand.ExecuteReader(); 
                while (dataReader.Read())
                {
                    Console.WriteLine(dataReader[0].ToString() + "\t" + dataReader[1].ToString() + "\t" + dataReader[2].ToString() + "\t");
                }



                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}