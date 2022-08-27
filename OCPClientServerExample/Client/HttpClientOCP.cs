using OCPClientServerExample.Server;

namespace OCPClientServerExample.Client
{
    public class HttpClientOCP : IClient
    {
        private readonly IServer _server;

        public HttpClientOCP(IServer server)
        {
            _server = server;
        }

        public string Request(string request)
        {
            return _server.Response(request);
        }
    }
}
