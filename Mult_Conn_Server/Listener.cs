using System.Net;
using System.Net.Sockets;

namespace Mult_Conn_Server;
public class Listener
{
    Socket _socket;

    public bool Listening
    {
        get;
        private set;
    }

    public int Port
    {
        get;
        private set;
    }

    public Listener(int port)
    {
        Port = port;
        _socket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    }

    public void Start()
    {
        if (Listening)
        {
            return;
        }

        _socket.Bind(new IPEndPoint(0, Port));
        _socket.Listen(0);

        _socket.BeginAccept(Callback, null);

        Listening = true;
    }

    public void Stop()
    {
        if (!Listening)
        {
            return;
        }

        _socket.Close();
        _socket.Dispose();

        _socket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    }

    void Callback(IAsyncResult ar)
    {
        try
        {
            Socket _socket = this._socket.EndAccept(ar);

            if (SocketAccepted != null)
            {
                SocketAccepted(_socket);
            }

            this._socket.BeginAccept(Callback, null);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public delegate void SocketAcceptHandler(Socket e);
    public event SocketAcceptHandler SocketAccepted;
}
