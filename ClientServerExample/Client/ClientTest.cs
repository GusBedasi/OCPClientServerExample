using ClientServerExample.Server;

namespace ClientServerExample.Client
{
    public class ClientTest
    {
        private readonly ServerTest _serverTest;
        public ClientTest(ServerTest serverTest)
        {
            _serverTest = serverTest;
        }
        public string Request(string request, bool isHttp2 = false)
        {
            return _serverTest.Response(request, isHttp2);
        }
    }
}
