using SimpleMessagingApp.Business;
using SimpleMessagingApp.Data.Dto;
using SimpleMessagingApp.UI;

namespace SimpleMessagingApp
{
    public partial class ServerForm : Form
    {
        ClientRequest ClientRequest;
        public ServerForm()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var clientRequest = SetRequest();
            if (RequestControlService.ControlData(clientRequest))
            {
                ControlOrAddEntity(clientRequest);
                _ = ServerUtility.Listen(clientRequest);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SetRequest();

            if (RequestControlService.ControlData(ClientRequest))
            {
                ClientForm serverForm = new ClientForm(ClientRequest);
                serverForm.Show();
            }
        }

        private ClientRequest SetRequest()
        {
            return ClientRequest = new ClientRequest()
            {
                ServerNickName = nickNameTextBox.Text,
                IpAdress = serverIpTextBox.Text,
                Port = Convert.ToInt32(portNumberBox.Value),
            };
        }

        private void ControlOrAddEntity(ClientRequest clientRequest)
        {
            ServerService serverService = new ServerService();
            serverService.CreateServer(clientRequest.ServerNickName);
        }
    }
}