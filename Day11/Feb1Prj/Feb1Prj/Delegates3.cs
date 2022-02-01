using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Feb1Prj
{
    public delegate void prints(string s);
    public class PrintExample
    {
       
        static FileStream fs; //like a paper where something can be written
        static StreamWriter sw;  //like a pen object to write to a stream

        public static void WriteToScreen(string str)
        {
            Console.WriteLine("The string is {0}",str);
        }

        public static void WriteToFile(string s)
        {
            fs = new FileStream("E:\\message.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public static void sendString(prints ps)
        {
            ps("We are Learning Delegates"); //invoking the delegate
        }
    }
    class Delegates3
    {
        static void Main()
        {
            prints ps1 = new prints(PrintExample.WriteToScreen);
            prints ps2 = new prints(PrintExample.WriteToFile);
            PrintExample.sendString(ps1);
            PrintExample.sendString(ps2);
            Console.Read();
        }
    }
}
