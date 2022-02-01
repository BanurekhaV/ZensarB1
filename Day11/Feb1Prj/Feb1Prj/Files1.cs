using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Feb1Prj
{
    [Serializable]  //indicates that the below class object can be serialized
    class Files1
    {
        public int ID;
        public string Name;
        static void Main()
        {
            Files1 fileobj = new Files1();
            fileobj.ID = 1;
            fileobj.Name = "Dot Net";
            //write to a file using binary formatter
            BinaryFormatter bfobj = new BinaryFormatter();
            Stream stream = new FileStream("Datafile.txt", FileMode.Append, FileAccess.Write);
            bfobj.Serialize(stream, fileobj);
            stream.Close();

            //read from a file using binary formatter
            stream = new FileStream("Datafile.txt", FileMode.Open, FileAccess.Read);

            Files1 newfileobj = (Files1)bfobj.Deserialize(stream);
            Console.WriteLine(newfileobj.ID);
            Console.WriteLine(newfileobj.Name);
            Console.Read();

        }
    }
}
