using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DisconnectedPrj
{
    class Program
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection("data source = DESKTOP-PU8R89M\\BRSQL; initial catalog = Northwind; integrated security = true");
                //adapter to execute the sql command
                da = new SqlDataAdapter("select * from Region", con);
                con.Open();
                //dataset object to store data in the form of datatables
                DataSet ds = new DataSet();
                //adapter populates data in the dataset
                da.Fill(ds, "NorthwindRegion");
                //Datatable object with a name to store the rows and columns of the query output
                DataTable dt = ds.Tables["NorthwindRegion"];
                //iterating the datatable collection of rows and table
                foreach(DataRow row in dt.Rows)
                {
                    foreach(DataColumn col in dt.Columns)
                    {
                        Console.Write(row[col]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                /*Adding one more table to the same dataset
                Console.WriteLine("----------------");
                da = new SqlDataAdapter("select * from Shippers", con);
                da.Fill(ds, "NorthwindShippers");
                dt = ds.Tables["NorthwindShippers"];
                foreach (DataRow row1 in dt.Rows)
                {
                    foreach (DataColumn col1 in dt.Columns)
                    {
                        Console.Write(row1[col1]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }*/

                //inserting one new row into the datatable of the dataset
                //SqlCommandBuilder scb = new SqlCommandBuilder(da);
                da.Fill(ds);
                //inserting or adding one new row
                DataRow drow = ds.Tables["NorthwindRegion"].NewRow();
                drow["RegionID"] = 11;
                drow["RegionDescription"] = "Disconnected Region";
                //add the newly create row to the data table of the dataset
                ds.Tables["NorthwindRegion"].Rows.Add(drow);
               // da.UpdateCommand = scb.GetUpdateCommand();
               // dt.AcceptChanges();
                da.Update(ds,"NorthwindRegion");
                Console.WriteLine("--------------");
                dt = ds.Tables["NorthwindRegion"];

                foreach (DataRow row2 in dt.Rows)
                {
                    foreach (DataColumn col2 in dt.Columns)
                    {
                        Console.Write(row2[col2]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }

            }
            catch(SqlException e)
            {
                Console.WriteLine("Some problem");
            }
            Console.Read();
        }
    }
}
