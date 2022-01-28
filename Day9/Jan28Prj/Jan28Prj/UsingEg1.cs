using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Jan28Prj
{
    class UsingEg1
    {
        
        static void Main()
        {
            string multiplelines = @"This is line one
        This is Line Two
        Here comes Line 3
        Line Four arrived
        Final and fifth Line";
            //using (var reader= new StringReader(multiplelines))
            //{
            //    string item;
            //    do
            //    {
            //        item = reader.ReadLine();
            //        Console.WriteLine(item);
            //    } while (item != null);
            //}

            //using (var streamReader = new StreamReader("e:\\file1.txt"))
            //{
            //    Console.WriteLine(streamReader.ReadToEnd());
            //}

            //var streamreader = new StreamReader("e:\\file1.txt");
            //try
            //{             
            //    Console.WriteLine(streamreader.ReadToEnd());
            //}
            //finally
            //{
            //    if (streamreader != null)
            //        streamreader.Dispose();
            //}
            using(var mydisposable=new MyDisposableclass())
            {
                mydisposable.DoSomeWork();                
            }
            
                Console.Read();
        }
    }

    public class MyDisposableclass : IDisposable
    {
        //constructor
        public MyDisposableclass()
        {
            Console.WriteLine("Allocating Resources..");
        }
        //Normal method
        public void DoSomeWork()
        {
            Console.WriteLine("I am Using Alloted Resources");
        }

        public void Show()
        {
            Console.WriteLine("2nd Normal method of the class");
        }
        //implementation of the Interface method
        public void Dispose()
        {
            Console.WriteLine("Releasing Resources");
        }
    }
}
