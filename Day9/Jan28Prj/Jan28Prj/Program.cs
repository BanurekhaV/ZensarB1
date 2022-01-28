using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Jan28Prj
{
    //user defined exception class decl.
    class VotingException : ApplicationException
    {
        public VotingException(string msg) : base(msg)
        {

        }
    }

    class Vote
    {
        int age;

        public void AcceptAge()
        {
            Console.WriteLine("Enter Your Age:");
            age = Convert.ToInt32(Console.ReadLine());
            if(age<18)
            {
                throw (new VotingException("Age should be greater than 18"));
            }
            else
                Console.WriteLine("Thanks for Voting..");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vote v = new Vote();
            try
            {
                v.AcceptAge();
            }
            catch(VotingException ve)
            {
                WriteLine(ve.Message + " "+ ve.Source);
            }
            Console.Read();
           
        }
    }
}
