﻿namespace OCPClientServerExample.Server
{
    public class Http2ServerOCP : IServer
    {
        public string Response(string request)
        {
            return "Response 200 OK";
        }
    }
}
