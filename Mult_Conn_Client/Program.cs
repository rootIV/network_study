using System.Net.Sockets;

namespace Mult_Conn_Client;

public class Program
{
    static void Main(string[] args)
    {
        Socket _socket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        _socket.Connect("127.0.0.1", 8);
        _socket.Close();
        _socket.Dispose();
    }
}
