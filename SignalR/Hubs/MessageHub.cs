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
            return Clients.All.SendAsync("AgentGroup", message);
        }
        public Task SendMessageToUser(string connectionid,string message)
        {
            return Clients.Client(connectionid).SendAsync("AgentGroup", message);
        }
        public Task SendToCaller(string message)
        {
            return Clients.Caller.SendAsync("AgentGroup", message);
        }

        public Task SendMessageToAgent(string message)
        {
            return Clients.All.SendAsync("AgentGroup", message);
        }
        public Task JoinGroup(string group)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, group);
        }
        public Task SendMessageToGroup(string group, string message)
        {
            return Clients.Group(group).SendAsync("AgentGroup", message);
        }
        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("UserConnected", Context.ConnectionId);
            await base.OnConnectedAsync();
        }
        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await Clients.All.SendAsync("UserDisconnected", Context.ConnectionId);
            await base.OnDisconnectedAsync(exception);
        }



    }
}
