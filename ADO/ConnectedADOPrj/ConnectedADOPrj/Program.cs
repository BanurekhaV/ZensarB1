using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConnectedADOPrj
{
    class Program
    {
        //create all required objects
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        static void Main(string[] args)
        {
            // InsertData();
            DeleteData();
            SelectData();
            Console.Read();
        }

        //function to read the data from Sql Table
        static void SelectData()
        {
            con = getConnection();
            cmd = new SqlCommand("select * from employee", con);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Console.WriteLine("Employee Details ...");
                Console.WriteLine("----------------");
                Console.WriteLine("Employee Id :" + " "+ dr[0]);
                Console.WriteLine("Employee Name :" + " "+ dr[1]);
                Console.WriteLine("Employee Email :" + " " + dr[2]);
                Console.WriteLine("Employee Gender :" + " " + dr[3]);                            
                Console.WriteLine("Employee Salary :" + " " + dr[4]);
                Console.WriteLine("Employee Department :" + " " + dr[5]);
            }
        }
        static void InsertData()
        {
            try {
                con = getConnection();
                //with static data
                // cmd = new SqlCommand("insert into employee values(114,'Ado','ado@net.com','Female',12000,3)");
                //with user given data
                Console.WriteLine("Enter Employee Details Empid, Empname, Email, Gender,Salary, Dept");
                int eid, did;
                string ename, email, egender;
                float esal;
                eid = Convert.ToInt32(Console.ReadLine());
                ename = Console.ReadLine();
                email = Console.ReadLine();
                egender = Console.ReadLine();
                esal = Convert.ToSingle(Console.ReadLine());
                did = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("insert into employee values(@ecode,@empname,@empmail,@empgender,@empsal,@empdept)");
                cmd.Parameters.AddWithValue("@ecode", eid);
                cmd.Parameters.AddWithValue("@empname", ename);
                cmd.Parameters.AddWithValue("@empmail", email);
                cmd.Parameters.AddWithValue("@empgender", egender);
                cmd.Parameters.AddWithValue("@empsal", esal);
                cmd.Parameters.AddWithValue("@empdept", did);
                cmd.Connection = con;
                int no_ofrows = cmd.ExecuteNonQuery();
                if (no_ofrows > 0)
                {
                    Console.WriteLine("Record Inserted Successfully..");
                }
                else
                    Console.WriteLine("Oops !! encountered problem");
            }
            catch(SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }

        static void DeleteData()
        {
            con = getConnection();
            Console.WriteLine("Enter the id to be deleted:");
            int empid = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd1 = new SqlCommand("select * from employee where Empid=@eid", con);
            cmd1.Parameters.AddWithValue("@eid", empid);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while(dr1.Read())
            {
                for(int i=0; i<dr1.FieldCount;i++)
                {
                    Console.WriteLine(dr1[i]);
                }
            }
            con.Close();
            Console.WriteLine("Are you sure to delete this record ? Y/N");
            string status = Console.ReadLine();
            if(status=="y"||status=="Y")
            {
                cmd = new SqlCommand("delete from employee where empid=@eid");
                cmd.Parameters.AddWithValue("@eid", empid);
                con.Open();
                cmd.Connection = con;
               int res= cmd.ExecuteNonQuery();
                if(res>0)
                {
                    Console.WriteLine("Record deleted successfuly");
                }
                else
                    Console.WriteLine("Could not delete the record..");
            }
        }
        static SqlConnection getConnection()
        {
            con = new SqlConnection("data source=DESKTOP-PU8R89M\\BRSQL;initial catalog=ZensarDB;" +
                "integrated security=true");
            con.Open();
            return con;

        }
    }
}
