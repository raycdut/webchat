﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WebChat.Hubs
{
    public class WebChatHub : Hub
    {

        public override Task OnConnected()
        {
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            return base.OnDisconnected(stopCalled);

        }

        public override Task OnReconnected()
        {
            return base.OnReconnected();
        }
    }
}