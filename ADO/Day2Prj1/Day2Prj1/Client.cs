using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Prj1
{
    class Region
    {
        public int RegionId { get; set; }
        public string RegionDescription { get; set; }
       
        public void GetRegion()
        {
            Console.WriteLine("Enter Region ID:");
            RegionId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Region Description:");
            RegionDescription = Console.ReadLine();
        }
        public void DisplayRegion()
        {
            DataAccess da = new DataAccess();
           da.DisplayRegion();
        }

        public void InsertRegion()
        {
            //GetRegion();
            DataAccess da = new DataAccess();
            da.InsertRegion();
        }
    }

    class DataAccess
    {
        string connection = "data source=DESKTOP-PU8R89M\\BRSQL;initial catalog=Northwind;integrated security=true";
        static SqlConnection con;
        static SqlCommand cmd;
        SqlDataReader dr;
        public Region reg;
       private SqlConnection getConnection()
        {
            con = new SqlConnection(connection);
            con.Open();
            return con;
        }

        public void DisplayRegion()
        {
            try
            {
                con = getConnection();
                cmd = new SqlCommand("select * from Region", con);
                dr = cmd.ExecuteReader();
            
                while(dr.Read())
                {
                    Console.WriteLine(dr["RegionID"]+" "+dr["RegionDescription"]);
                }
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void InsertRegion()
        {
            con = getConnection();
            reg = new Region();
            reg.GetRegion();
            //reg.RegionId = 8;
            //reg.RegionDescription = "Testing Region";
            cmd = new SqlCommand("insert into region values(@rid,@rdesc)", con);
            cmd.Parameters.AddWithValue("@rid", reg.RegionId);
            cmd.Parameters.AddWithValue("@rdesc", reg.RegionDescription);
            int result = cmd.ExecuteNonQuery();
            if(result>0)
            {
                Console.WriteLine("Inserted one Region");
            }
        }
        
    }
    class Client
    {
        static void Main(string[] args)
        {
            Region r = new Region();
            r.InsertRegion();
            r.DisplayRegion();
            Console.ReadLine();
        }
    }
}
