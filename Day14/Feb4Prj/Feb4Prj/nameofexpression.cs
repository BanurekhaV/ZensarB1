using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb4Prj
{
    class nameofexpression
    {
        int[] array = new int[5];

        public static void Main()
        {
            nameofexpression ne =new nameofexpression();
            try
            {
                ne.Show(ne.array);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("The name of the method is :" + nameof(ne.Show)+ " " + "the variable is:" + nameof(ne.array));
            }
            Console.Read();
        }
        public int Show(int[] x)
        {
            x[5] = 10;
            return x[5];
        }
    }
}
