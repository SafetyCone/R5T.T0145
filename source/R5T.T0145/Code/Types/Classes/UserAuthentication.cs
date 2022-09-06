using System;

using R5T.T0142;


namespace R5T.T0145
{
    [DataTypeMarker]
    public class UserAuthentication
    {
        public string Password { get; set; }
        public string PrivateKeyFilePath { get; set; }
    }
}
