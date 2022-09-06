using System;
using System.Collections.Generic;

using R5T.T0142;


namespace R5T.T0145
{
    [DataTypeMarker]
    public class RemoteServerConnectionSet
    {
        public Dictionary<string, RemoteServerConnection> RemoteServerConnectionsByFriendlyName { get; } = new();
        public Dictionary<string, UserAuthentication> UserAuthenticationsByFriendlyName { get; } = new();
    }
}
