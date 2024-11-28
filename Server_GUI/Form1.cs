using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server_GUI;

public partial class Form1 : Form
{
    Socket _sock;
    Socket _acc;

    public Form1()
    {
        InitializeComponent();

        _sock = Socket();

        FormClosing += new FormClosingEventHandler(Form1_FormClosing);
    }

    private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
    {
        _sock.Close();
    }

    Socket Socket()
    {
        return new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    }

    private void Connect_Btn_Click(object sender, EventArgs e)
    {
        try
        {
            _sock.Connect(new IPEndPoint(IPAddress.Parse(textBox1.Text), 3));

            new Thread(delegate()
            {
                Read();
            }).Start();
        }
        catch
        {
            MessageBox.Show("CONNECTION FAILED!");
        }
    }

    void Read()
    {
        while (true)
        {
            try
            {
                byte[] buffer = new byte[255];

                int rec = _sock.Receive(buffer, 0, buffer.Length, SocketFlags.None);

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
                _sock.Close();
                break;
            }
        }

        Application.Exit();
    }

    private void Send_Btn_Click(object sender, EventArgs e)
    {
        byte[] data = Encoding.Default.GetBytes(textBox2.Text);

        _sock.Send(data, 0, data.Length, SocketFlags.None);
    }
}
