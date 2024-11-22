using System.Net;
using System.Net.Sockets;
using System.Text;

class Server
{
    static void Main(string[] args)
    {
        Socket socket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        socket.Bind(new IPEndPoint(0, 1999));
        socket.Listen(0);

        Console.WriteLine("Aguardando conexão...");

        Socket acc = socket.Accept();
        Console.WriteLine("Cliente conectado.");

        byte[] buffer = new byte[4096];
        int rec = acc.Receive(buffer, 0, buffer.Length, SocketFlags.None);
        Array.Resize(ref buffer, rec);

        string receivedMessage = Encoding.Default.GetString(buffer);
        Console.WriteLine("Received: {0}", receivedMessage);

        string response = "Message received.";
        byte[] responseBuffer = Encoding.Default.GetBytes(response);
        acc.Send(responseBuffer, 0, responseBuffer.Length, SocketFlags.None);

        acc.Shutdown(SocketShutdown.Both);
        acc.Close();
        socket.Close();

        Console.ReadKey();

        //int port = 5000;
        //TcpListener server = new TcpListener(IPAddress.Any, port);

        //Console.WriteLine("Iniciando o servidor...");
        //server.Start();
        //Console.WriteLine($"Servidor escutando na porta {port}...");

        //while (true)
        //{
        //    Console.WriteLine("Aguardando conexão...");
        //    TcpClient client = server.AcceptTcpClient();
        //    Console.WriteLine("Cliente conectado!");

        //    NetworkStream stream = client.GetStream();

        //    byte[] buffer = new byte[1024];
        //    int bytesRead = stream.Read(buffer, 0, buffer.Length);
        //    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
        //    Console.WriteLine($"Mensagem recebida: {message}");

        //    string response = "Mensagem recebida com sucesso!";
        //    byte[] responseBytes = Encoding.UTF8.GetBytes(response);
        //    stream.Write(responseBytes, 0, responseBytes.Length);

        //    client.Close();
        //}
    }
}
