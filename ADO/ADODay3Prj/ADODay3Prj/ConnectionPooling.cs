using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ADODay3Prj
{
    class ConnectionPooling
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            string connection = "data source=DESKTOP-PU8R89M\\BRSQL; database=ZensarDB;integrated security=true;Pooling=true;";
            stopwatch.Start();
            for(int i=0;i<1000;i++)
            {
                SqlConnection con = new SqlConnection(connection);
                con.Open();
                con.Close();
            }
            stopwatch.Stop();
            Console.WriteLine($"When Pooling=true :Time Taken is :{stopwatch.ElapsedMilliseconds}milliseconds");
            Console.Read();
        }
    }
}
