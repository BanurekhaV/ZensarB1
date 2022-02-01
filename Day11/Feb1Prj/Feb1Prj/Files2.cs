using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Feb1Prj
{
    class Files2
    {
        public void ReadData()
        {
            FileStream fs = new FileStream("message.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            //position the file pointer at the beginning of the file
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            //Read till the end of file
            string str = sr.ReadLine();
            while(str!=null)
            {
                Console.WriteLine("{0}",str);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }

        public void WriteData()
        {
            FileStream fs = new FileStream("message.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("Enter data to be written :");
            string str = Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public void Directory_FileInfo()
        {
            DirectoryInfo dirinfo = new DirectoryInfo(@"E:\ZensarDir");
            if(dirinfo.Exists)
            {
                Console.WriteLine("Directory alreay exists");
                //return;
            }
            else
            {
                dirinfo.Create();
                Console.WriteLine("Directory Created");
            }        
        }
        public void GetDirectories()
        {
            //code to get all subdirectories
            DirectoryInfo mydirobj = new DirectoryInfo(@"E:\Banu");

            if (mydirobj.Exists)
            {
                DirectoryInfo[] directories = mydirobj.GetDirectories();
                foreach (object dirnames in directories)
                {
                    Console.WriteLine(dirnames.ToString());
                }
            }
            else
            {
                Console.WriteLine("The given Directory does not exists");
            }
        }
        public void GetFiles()
        {
            //code for getting all files inside the directory
            DirectoryInfo mydirobj = new DirectoryInfo(@"E:\");
            FileInfo[] f = mydirobj.GetFiles();
            foreach(FileInfo file in f)
            {
                Console.WriteLine("FileName :{0} Size :{1}", file.Name,file.Length);
            }
        }
        static void Main()
        {
            Files2 file2 = new Files2();
            //file2.WriteData();
            //file2.ReadData();
            file2.Directory_FileInfo();
            Console.WriteLine("==========Getting all Sub directories=========");
            file2.GetDirectories();
            Console.WriteLine("==========Getting all Files in te directory==========");
            file2.GetFiles();
            Console.Read();
        }


    }
}
