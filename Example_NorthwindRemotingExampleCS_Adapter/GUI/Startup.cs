using System;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using Interfaces;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.GUI
{
	/// <summary>
	/// Simple startup class with the main.
	/// </summary>
	public class Startup
	{
		// alter the server name here where the service is hosted.
		private const string SERVERNAME = "localhost";

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			// grab service object first. 			
			TcpChannel channel = new TcpChannel();
			ChannelServices.RegisterChannel(channel, true);

			MarshalByRefObject o = (MarshalByRefObject)RemotingServices.Connect(typeof(IService), string.Format("tcp://{0}:65100/theEndPoint", SERVERNAME));
			IService service = o as IService;
			if(service == null)
			{
				throw new Exception("Service couldn't be obtained. Aborting");
			}

			MainForm.DalService = service;

			// switch on FastSerialization
			SerializationHelper.Optimization = SerializationOptimization.Fast;

			MainForm mainWindow = new MainForm();
					
			Application.EnableVisualStyles();
			Application.Run(mainWindow);
		}
	}
}
