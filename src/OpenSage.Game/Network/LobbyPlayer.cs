﻿using System;
using System.Net;

namespace OpenSage.Network
{
    public class LobbyPlayer
    {
        public string Username { get; set; }
        public bool IsHosting { get; set; }
        public IPEndPoint EndPoint { get; set; }
        public DateTime LastSeen { get; set; }
        public int ProcessId { get; internal set; }
    }
}
