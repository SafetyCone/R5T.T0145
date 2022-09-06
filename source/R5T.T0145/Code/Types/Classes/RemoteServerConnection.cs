using System;

using R5T.T0142;


namespace R5T.T0145
{
    [DataTypeMarker]
    public class RemoteServerConnection
    {
        public string HostUrl { get; set; }
        public string Username { get; set; }
        public string UserAuthenticationFriendlyName { get; set; }
    }
}
