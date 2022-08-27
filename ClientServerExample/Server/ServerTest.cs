namespace ClientServerExample.Server
{
    public class ServerTest
    {
        public string Response(string request, bool isHttp2 = false)
        {
            return isHttp2 ? "Response HTTP2 200 OK" : "Response HTTP 200 OK";
        }
    }
}
