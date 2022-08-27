namespace OCPClientServerExample.Server
{
    public class HttpServerOCP : IServer
    {
        public string Response(string request)
        {
            return "Response HTTP 200 OK";
        }
    }
}
