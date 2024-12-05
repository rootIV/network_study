using System.Net;
using System.Net.Sockets;

namespace Mult_Conn_Server;

public class Listener
{
    internal Socket _socketServer;
    public bool Listening { get; private set; }
    public int Port { get; private set; }
    public delegate void SocketAcceptHandler(Socket e);
    public event SocketAcceptHandler SocketAccepted;

    public Listener(int port)
    {
        Port = port;
        _socketServer = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    }

    public void Start()
    {
        if (Listening) {
            return;
        }

        _socketServer.Bind(new IPEndPoint(0, Port));
        _socketServer.Listen(0);

        _socketServer.BeginAccept(Callback, null);

        Listening = true;
    }

    public void Stop()
    {
        if (!Listening) {
            return;
        }

        _socketServer.Close();
        _socketServer.Dispose();

        _socketServer = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    }

    void Callback(IAsyncResult ar)
    {
        try {
            Socket _socket = this._socketServer.EndAccept(ar);

            if (SocketAccepted != null) {
                SocketAccepted(_socket);
            }

            this._socketServer.BeginAccept(Callback, null);
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
    }
}
