using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TransactionPrj
{
    class Program
    {
        static SqlConnection con;
        static SqlCommand cmd;
        public static string connectionString = "data source=DESKTOP-PU8R89M\\BRSQL; initial catalog=ZensarDB;integrated security=true";
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Before Transaction.......");
                GetAccountsDetails();
                MoneyTransfer();
                Console.WriteLine("After Transaction.......");
                GetAccountsDetails();
            }
            catch(SqlException s)
            {
                Console.WriteLine("OOPS !! something went wrong!!" + " "+s.Message);
            }
            Console.Read();
        }
        static void MoneyTransfer()
        {
            using (con = new SqlConnection(connectionString))
            {
                //open the connection before we begin the transaction
                con.Open();
                //create a transaction object by calling the BeginTRansaction
                //method of the connection object
                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    //Associate the first update command with the transaction
                    cmd = new SqlCommand("update Accounts set Balance=Balance - 500 where AccountNumber='Account1'", con, transaction);
                    cmd.ExecuteNonQuery();
                    //Associate the second update command with the transaction
                    cmd = new SqlCommand("update Accounts set Balance = Balance + 500 where AccountNumber='Account2'", con, transaction);
                    cmd.ExecuteNonQuery();
                    //If everything goes well then commit the transaction
                    transaction.Commit();
                    Console.WriteLine("Transaction Successfull..");
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    Console.WriteLine("Transaction Failed");
                }

            }
        }

        static void GetAccountsDetails()
        {
            using (con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("Select * from Accounts", con);
                SqlDataReader sdr = cmd1.ExecuteReader();
                while(sdr.Read())
                {
                    Console.WriteLine(sdr["AccountNumber"]+" "+ sdr["CustomerName"]+" "+ sdr["Balance"]);
                }
            }

        }
    }
}
