using Mult_Conn_Server;
using System.Net.Sockets;
using System.Text;

namespace Mult_Conn_Server_GUI;

public partial class Form1 : Form {
    Listener _listener;

    public Form1() {
        InitializeComponent();
        _listener = new(8);
        _listener.SocketAccepted += new Listener.SocketAcceptHandler(Listener_SocketAccepted);
        Load += new EventHandler(Main_Load);
    }

    private void Main_Load(object sender, EventArgs e) {
        _listener.Start();
    }

    private void Listener_SocketAccepted(Socket e) {
        Client client = new(e);
        client.hasReceived += new Client.ClientReceiveHandler(Client_Received);
        client.hasDisconnected += new Client.ClientDisconnectedHandler(Client_Disconnected);

        Invoke((MethodInvoker)delegate {
            ListViewItem listViewI = new();
            listViewI.Text = client.EndPoint.ToString();
            listViewI.SubItems.Add(client.Id);
            listViewI.SubItems.Add("XX");
            listViewI.SubItems.Add("XX");
            listViewI.Tag = client;

            List_Clients.Items.Add(listViewI);
        });
    }

    private void Client_Disconnected(Client sender) {
        Invoke((MethodInvoker)delegate {
            for(int i = 0; i < List_Clients.Items.Count; i++) {
                Client client = List_Clients.Items[i].Tag as Client;

                if(client.Id == sender.Id) {
                    List_Clients.Items.RemoveAt(i);
                    break;
                }
            }
        });
    }

    private void Client_Received(Client sender, byte[] data) {
        Invoke((MethodInvoker)delegate {
            for(int i = 0; i < List_Clients.Items.Count; i++) {
                Client client = List_Clients.Items[i].Tag as Client;

                if(client.Id == sender.Id) {
                    List_Clients.Items[i].SubItems[2].Text = Encoding.Default.GetString(data);
                    List_Clients.Items[i].SubItems[3].Text = DateTime.Now.ToString();
                    break;
                }
            }
        });
    }
}
