using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client_GUI;

public partial class Form1 : Form
{
    Socket _sock;
    Socket _acc;

    public Form1()
    {
        InitializeComponent();
    }

    private static Socket Socket()
    {
        return new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    }

    private void Listen_Btn_Click(object sender, EventArgs e)
    {
        _sock = Socket();

        _sock.Bind(new IPEndPoint(0, 3));
        _sock.Listen();

        new Thread(delegate ()
        {
            _acc = _sock.Accept();
            MessageBox.Show("CONNECTION ACCEPTED.");
            _sock.Close();

            while (true)
            {
                try
                {
                    byte[] buffer = new byte[255];

                    int rec = _acc.Receive(buffer, 0, buffer.Length, SocketFlags.None);

                    if (rec <= 0)
                    {
                        throw new SocketException();
                    }

                    Array.Resize(ref buffer, rec);

                    Invoke((MethodInvoker)delegate
                    {
                        listBox1.Items.Add(Encoding.Default.GetString(buffer));
                    });
                }
                catch
                {
                    MessageBox.Show("DISCONNECTION!");
                    break;
                }
            }
        Application.Exit();
        }).Start();
    }

    private void Send_Btn_Click(object sender, EventArgs e)
    {
        byte[] data = Encoding.Default.GetBytes(textBox1.Text);

        _acc.Send(data, 0, data.Length, SocketFlags.None);
    }
}
