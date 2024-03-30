using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorChatAppWASM.Server.Hubs
{
	public class ChatHub:Hub
	{

		public async Task SendText(ChatMessage chatMessage)
		{
			await Clients.All.SendAsync("ReceiveText", chatMessage);
		}



		public async Task SendImage(ChatMessage chatMessage)
		{
			await Clients.All.SendAsync("ReceiveImage", chatMessage);
		}
	}
}
