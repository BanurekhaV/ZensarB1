using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels;

using System.Text;
using System.Threading.Tasks;

namespace RemoteServer
{
    public class RemotingServer
    {
        public RemotingServer()
        {

        }
    }

    //service class
    public class Service:MarshalByRefObject
    {
        public void WriteMessage(int num1, int num2)
        {
            Console.WriteLine(Math.Max(num1,num2));
        }
    }

    //server class
    class Server
    {
        static void Main(string[] args)
        {
            //create a new Channel
            HttpChannel channel = new HttpChannel(8081);
            //register the created channel
            ChannelServices.RegisterChannel(channel);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Service), "Service", WellKnownObjectMode.Singleton);
            Console.WriteLine("Server Services Started at Port No:8081.............");
            Console.WriteLine("Please press Enter to Stop the Server..");
            Console.Read();
        }
    }
}
