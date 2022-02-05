using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Threading;

using BaseLib;

namespace Server
{
    class MyRemoteObject : BaseRemoteObject
    {
        int mvalue;
        public MyRemoteObject()
        {
            Console.WriteLine("MyRemoteOBject called..New Remote Object Created");
        }
        //implement the abstract methods
        //1. 
        public override void setValue(int pvalue)
        {
            Console.WriteLine("MyRemoteObject.setValue() old={0} new={1}", mvalue, pvalue);
            Console.WriteLine("Waiting 5 sec.. ");
            Thread.Sleep(5000);
            mvalue = pvalue;
            Console.WriteLine("Value is Set..");
        }

        //2. 
        public override int getValue()
        {
            Console.WriteLine("MyRemoteObject.getValue()={0}", mvalue);
            return mvalue;
        }

        //3.
        public override string getText()
        {
            Console.WriteLine("MyRemoteObject.getText() called");
            Console.WriteLine("Waiting 5 sec..");
            Thread.Sleep(5000);
            Console.WriteLine("Returning the Text");
            return "Zensar .Net Remoting";
        }
    }
        class ServerStartUp
        { 
        //attribute to inform that the server has to run in a single thread Apartment
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Starting the Server on Port No. 1237...");
            HttpChannel chnl = new HttpChannel(1237);
            ChannelServices.RegisterChannel(chnl);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(MyRemoteObject), "RemoteObject", WellKnownObjectMode.Singleton);
            Console.WriteLine("Press enter to Exit..");
            Console.Read();
        }
    }
}
