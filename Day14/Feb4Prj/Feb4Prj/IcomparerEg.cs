using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb4Prj
{
    public class Display
    {
        public int PPI { get; set; }
        public string Resolution { get; set; }
        public string size { get; set; }
    }
    public class SortDisplay : IComparer<Display>
    {
        public int Compare(Display x, Display Y)
        {
            Display first = x;
            Display second = Y;
            return first.PPI.CompareTo(second.PPI);
        }
    }
    class IcomparerEg
    {
        public static void Main()
        {
            List<Display> displays = new List<Display>()
            {
                new Display()
                {
                    PPI=224,
                    Resolution="1080 * 1920",
                    size="6.4"
                },
                new Display()
                {
                    PPI=300,
                    Resolution="564 * 720",
                    size="8.4"
                },
                new Display()
                {
                    PPI=115,
                    Resolution="1080 * 1920",
                    size="7.5"
                },
                new Display()
                {
                    PPI=160,
                    Resolution="880 * 980",
                    size="6.4"
                }
            };
            SortDisplay sd = new SortDisplay();
            displays.Sort(sd);
            foreach(var item in displays)
            {
                Console.WriteLine($"PPI :{item.PPI}, Resolution :{item.Resolution} and the Size is {item.size}");
            }
                        
            Console.Read();
        }
    }
}
