using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace RemotingService
{
	public class Program
	{
		static void Main(string[] args)
		{
			// register a channel and assign the service type to it. This opens the service to the outside world at TCP port 65100.
			TcpChannel channel = new TcpChannel(65100);
			ChannelServices.RegisterChannel(channel, true);

			Type serverType = Type.GetType("RemotingService.Service");
			RemotingConfiguration.RegisterWellKnownServiceType(serverType, "theEndPoint", WellKnownObjectMode.Singleton);

			// switch on FastSerialization
			SerializationHelper.Optimization = SerializationOptimization.Fast;

			Console.WriteLine("Press Enter To Exit");
			Console.ReadLine();
		}
	}
}
