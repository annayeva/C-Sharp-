using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Red03
{
    public class ChatHub : Hub
    {
        public void MessageAll(string name, string text)
        {
            Clients.All.newMessage(name, text);
        }
    }
}