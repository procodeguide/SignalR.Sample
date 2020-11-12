using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.SignalR.Hubs
{
    public class MessageHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            if (string.IsNullOrEmpty(user))
                await Clients.All.SendAsync("ReceiveMessageHandler", message);
            else
                await Clients.User(user).SendAsync("ReceiveMessageHandler", message);
        }
    }
}
