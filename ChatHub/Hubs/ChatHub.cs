using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatHub.Hubs
{
	public class Chat : Hub
	{
		private readonly string SEND_TO_ALL = "SendToAll";
		public void SendToAll(string name, string message)
		{
			Clients.All.SendAsync(SEND_TO_ALL, name, message);
		}
	}
}
