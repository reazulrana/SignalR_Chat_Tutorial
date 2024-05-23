using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.Hubs
{
    public class MessageHub:Hub
    {


        public Task SendMessageToAll(string message)
        {
            return Clients.All.SendAsync("ReceiveMessage", message);
        }


        public Task sendtocaller(string message)
        {
            return Clients.Caller.SendAsync("AgentGroup", message);
        }
        public Task SendMessageToAgent(string message)
        {
            return Clients.All.SendAsync("AgentGroup", message);
        }


    }
}
