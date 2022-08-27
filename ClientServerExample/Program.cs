using ClientServerExample.Client;
using ClientServerExample.Server;

var server = new ServerTest();
var client = new ClientTest(server);

var response = client.Request("Teste");

Console.WriteLine(response);
Console.ReadLine();