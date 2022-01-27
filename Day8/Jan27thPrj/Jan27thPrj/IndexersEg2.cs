using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27thPrj
{
    class Authors
    {
        private string[] namesofAuthor = new string[3];
        private string publisher_Name;
        //defining indexer
        public string this[int flag]
        {
            get
            {
                string temp = namesofAuthor[flag];
                return temp;
                //return namesofAuthor[flag];
            }
            set
            {
                namesofAuthor[flag] = value;
            }
        }
        public string this[string flag]
        {
            get { string temp = namesofAuthor[2];
                return temp;
            }
            set { namesofAuthor[2] = value; }
        }

        public string this[float f]
        {
            get
            {
                string temp = namesofAuthor[2];
                return temp;
            }
            set { namesofAuthor[2] = value; }
        }
        //property decl for publisher name
        public string Publisher
        {
            get { return publisher_Name; }
            set { publisher_Name = value; }
        }
    }
    class IndexersEg2
    {
        static void Main()
        {
            Authors authors = new Authors();
            authors[0] = "Sydney Sheldon";
            authors[1] = "James Patterson";
            authors[2] = "Danielle Steel";
            authors.Publisher = "Royal Press";
            Console.WriteLine($"The three Famous Authors of Fiction are{authors[0]},{authors[1]},{authors[2]} respectively" +
                $" publishing their novels through {authors.Publisher}");
            authors["0"] = "Agatha Christie";
            Console.WriteLine(authors["0"]);
            authors[1.0f] = "Hardly Chase";
            Console.WriteLine(authors[1.0f]);
            Console.Read();
        }
    }
}
