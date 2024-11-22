using System.Net;
using System.Net.Sockets;
using System.Text;

class Client
{
    static void Main(string[] args)
    {
        Socket socket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        IPEndPoint endPoint = new(IPAddress.Parse("127.0.0.1"), 1999);
        socket.Connect(endPoint);

        Console.Write("Enter Message: ");

        string msg = Console.ReadLine();
        byte[] msgBuffer = Encoding.Default.GetBytes(msg);
        socket.Send(msgBuffer, 0, msgBuffer.Length, 0);

        byte[] buffer = new byte[255];
        int rec = socket.Receive(buffer, 0, buffer.Length, 0);

        Array.Resize(ref buffer, rec);

        string response = Encoding.Default.GetString(buffer);
        Console.WriteLine("Server response: {0}", response);

        socket.Shutdown(SocketShutdown.Both);
        socket.Close();

        Console.ReadKey();
        //string serverAddress = "127.0.0.1";
        //int port = 5000;

        //while (true)
        //{
        //    Console.WriteLine("Conectando ao servidor...");
        //    using (TcpClient client = new(serverAddress, port))
        //    {
        //        Console.WriteLine("Conectado!");

        //        NetworkStream stream = client.GetStream();

        //        Console.Write("Digite uma mensagem para enviar ao servidor (ou 'exit' para sair): ");
        //        string message = Console.ReadLine();

        //        if (message.Equals("exit", StringComparison.CurrentCultureIgnoreCase))
        //        {
        //            break;
        //        }

        //        byte[] messageBytes = Encoding.UTF8.GetBytes(message);
        //        stream.Write(messageBytes, 0, messageBytes.Length);

        //        byte[] buffer = new byte[1024];
        //        int bytesRead = stream.Read(buffer, 0, buffer.Length);
        //        string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);

        //        Console.WriteLine($"Resposta do servidor: {response}");
        //    }

        //}

        //Console.WriteLine("Cliente encerrado.");
    }
}
