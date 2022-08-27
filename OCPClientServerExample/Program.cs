using OCPClientServerExample.Client;
using OCPClientServerExample.Server;

var httpServer = new HttpServerOCP();
var http2Server = new Http2ServerOCP();

var httpClient = new HttpClientOCP(http2Server);

var response = httpClient.Request("Teste");

Console.WriteLine(response);

Console.ReadLine();