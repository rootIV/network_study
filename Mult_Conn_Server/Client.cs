using System.Net;
using System.Net.Sockets;

namespace Mult_Conn_Server;

public class Client {
    public string Id { get; private set; }
    public IPEndPoint EndPoint { get; private set; }
    Socket _socketClient;
    
    public Client(Socket acceptedSocket){
        _socketClient = acceptedSocket;
        Id = Guid.NewGuid().ToString();
        EndPoint = (IPEndPoint)_socketClient.RemoteEndPoint;
        _socketClient.BeginReceive(new byte[] { 0 }, 0, 0, 0, Callback, null);
    }

    void Callback(IAsyncResult asyncR) {
        try {
            _socketClient.EndReceive(asyncR);

            byte[] buffer = new byte[8192];

            int receivedData = _socketClient.Receive(buffer, buffer.Length, 0);

            if(receivedData < buffer.Length) {
                Array.Resize<byte>(ref buffer, receivedData);
            }

            if(hasReceived != null) {
                hasReceived(this, buffer);
            }

            _socketClient.BeginReceive(new byte[] {0}, 0, 0, 0, Callback, null);
        }
        catch(Exception ex) {
            Console.WriteLine(ex.Message);
            Close();

            if(hasDisconnected != null) {
                hasDisconnected(this);
            }
        }
    }

    public void Close() { 
        _socketClient.Close();
        _socketClient.Dispose();
    }

    public delegate void ClientReceiveHandler(Client sender, byte[] data);
    public delegate void ClientDisconnectedHandler(Client sender);
    public event ClientReceiveHandler hasReceived;
    public event ClientDisconnectedHandler hasDisconnected;

    public void Start() { 

    }
}
