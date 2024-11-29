using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TextClient;

public partial class Form1 : Form
{
    Socket _socket;

    public Form1()
    {
        InitializeComponent();
    }

    private void Btn_Connect_Click(object sender, EventArgs e)
    {
        _socket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        try
        {
            _socket.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8));
        }
        catch
        {
            MessageBox.Show("Unable to connect!");
        }
    }

    private void Btn_Send_Text_Click(object sender, EventArgs e)
    {
        byte[] data = Encoding.Default.GetBytes(TextBox.Text);

        _socket.Send(BitConverter.GetBytes(data.Length), 0, 4, 0);
        _socket.Send(data);
    }
}
