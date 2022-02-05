using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;

using BaseLib;

namespace Client
{
    class ClientApplication
    {
        delegate void SetValueDelegate(int pvalue);
        delegate int GetValueDelegate();
        delegate string GetTextDelegate();
        [STAThread]
        static void Main(string[] args)
        {
            DateTime start = System.DateTime.Now;
            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel);
            BaseRemoteObject obj =(BaseRemoteObject) Activator.GetObject(typeof(BaseRemoteObject), "http://localhost:1237/RemoteObject");
            SetValueDelegate svd = new SetValueDelegate(obj.setValue);
            GetValueDelegate gvd = new GetValueDelegate(obj.getValue);
            GetTextDelegate gtd = new GetTextDelegate(obj.getText);
            Console.WriteLine("Client calls started...");
            Console.WriteLine("Set the value for the field..");
            svd.Invoke(5);
            Console.WriteLine("Check the Value that has been set..");
            int retval = gvd();
            Console.WriteLine("The Value that has been set is" + " "+ retval);
            Console.WriteLine("Get the Text from the server...");
            string text = gtd();
            Console.WriteLine("Displaying the Text..{0} ",text);
            DateTime end = System.DateTime.Now;
            TimeSpan ts = end.Subtract(start);
            Console.WriteLine("Client : Remote Execution started at {0} and ended at {1}",start,end);
            Console.WriteLine("The Total duration of execution was :{0}",ts.Seconds);
            Console.Read();
        }
    }
}
