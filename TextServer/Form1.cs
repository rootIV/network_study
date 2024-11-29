using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TextServer;

public partial class Form1 : Form
{
    Socket _socket;
    Socket _acc;

    public Form1()
    {
        InitializeComponent();
    }

    private void Btn_Listen_Click(object sender, EventArgs e)
    {
        _socket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        _socket.Bind(new IPEndPoint(0, 8));
        _socket.Listen(0);

        _acc = _socket.Accept();

        _socket.Close();

        new Thread(delegate ()
        {
            while (true)
            {
                byte[] sizeBuf = new byte[4];

                _acc.Receive(sizeBuf, 0, sizeBuf.Length, SocketFlags.None);

                int size = BitConverter.ToInt32(sizeBuf, 0);

                MemoryStream ms = new();

                while (size > 0)
                {
                    byte[] buffer;

                    if (size < _acc.ReceiveBufferSize)
                    {
                        buffer = new byte[size];
                    }
                    else
                    {
                        buffer = new byte[_acc.ReceiveBufferSize];
                    }

                    int rec = _acc.Receive(buffer, 0, buffer.Length, SocketFlags.None);

                    size -= rec;

                    ms.Write(buffer, 0, buffer.Length);
                }

                ms.Close();

                byte[] data = ms.ToArray();

                ms.Dispose();

                Invoke((MethodInvoker)delegate
                {
                    TextBox.Text = Encoding.Default.GetString(data);
                });
            }
        }).Start();
    }
}
