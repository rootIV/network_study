using System.Net.Sockets;
using System.Text;

namespace Mult_Conn_Client_GUI;

public partial class Form1 : Form {
    Socket _socket;

    public Form1() {
        InitializeComponent();
        _socket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    }

    private void Btn_Connect_Click(object sender, EventArgs e) {
        _socket.Connect("127.0.0.1", 8);
        MessageBox.Show("Connected");
    }

    private void Btn_Send_Click(object sender, EventArgs e) {
        int socketStatus = _socket.Send(Encoding.Default.GetBytes(Txt_Msg.Text));

        if(socketStatus > 0) {
            MessageBox.Show("Data Sent");
        }
    }

    private void Btn_Close_Click(object sender, EventArgs e) {
        _socket.Close();
        _socket.Dispose();
        Close();
    }
}
