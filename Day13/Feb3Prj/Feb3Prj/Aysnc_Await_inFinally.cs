using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb3Prj
{
    class Aysnc_Await_inFinally
    {
        static void Main()
        {
            // addAsync();
            FileRead fr = new FileRead();
            Console.WriteLine("Instantiated File Read");
            fr.filereadoperation();

            Console.Read();
        }
        async static Task addAsync()
        {
            try
            {
                int[] arr = new int[5];
                arr[10] = 2;
            }
            catch (Exception e)
            {
                //use await in catch
                await otherException();
                Console.WriteLine("Waiting for some task completion");
            }
            finally
            {
                //using await in finally
                await releaseResources();
            }
        }

        async static Task otherException()
        {
            Console.WriteLine("There was an Index Out of Range Exception in the Array -arr");
        }

        async static Task releaseResources()
        {
            Console.WriteLine("All alloted resources have been released");
        }
    }
    class FileRead
    {
        public FileRead()
        {
                
        }
        public async void filereadoperation()
        {
            try
            {
                StreamReader sr = File.OpenText(@"E:\message1.txt");
                Console.WriteLine($"The first line of the file is {sr.ReadLine()}");
                sr.Close();
            }
            catch { await FileNotFound();
                Console.WriteLine("Task Filenot found completed"); 
            }
            finally { await Exitprg(); }
        }

        async Task FileNotFound()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("The Specified File is not found in the location..");
            }
        }
        async Task Exitprg()
        {
            Console.WriteLine("\n Press any key to Exit..");
        }
    }
}