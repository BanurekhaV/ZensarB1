using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27thPrj
{
    class ExceptionsEg
    {
        static void Main()
        {
            int a, b, c;
            try
            {
                Console.WriteLine("Enter 2 nos.:");
                a = Convert.ToInt32(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = a / b;
                int[] arr = { 11, 22, 33, 44 };
                Console.WriteLine(arr[6]);
                Console.WriteLine(c);
            }
            
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Source + " " + e.Message);
                Console.WriteLine("Please enter only positive integers > 0");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Your are trying to read beyond your capacity");
            }
            catch (Exception e)
            {
                // Console.WriteLine("OOPs!! something went wrong...contact admin");
                Console.WriteLine(e.Message);
            }

            Console.Read();
        }
    }
}
