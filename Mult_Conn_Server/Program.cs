using System.Net.Sockets;

namespace Mult_Conn_Server;

internal class Program
{
    static Listener _listener;
    static List<Socket> _sockets;
    static void Main(string[] args)
    {
        _listener = new(8);
        _listener.SocketAccepted += new Listener.SocketAcceptHandler(AcceptedSocket);
        _listener.Start();

        _sockets = [];

        Console.Read();
    }

    static void AcceptedSocket(Socket socket)
    {
        Console.WriteLine("new connection: {0}\n{1}\n==============", socket.RemoteEndPoint, DateTime.Now);
        _sockets.Add(socket);
    }
}
