using SimpleMessagingApp.Business;
using SimpleMessagingApp.Data.Dto;
using Message = SimpleMessagingApp.Data.Entity.Message;

namespace SimpleMessagingApp.UI
{
    public partial class ClientForm : Form
    {
        ClientRequest clientRequest;
        public ClientForm(ClientRequest clientRequest)
        {
            this.clientRequest = clientRequest;
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            clientRequest.Message = messageTextBox.Text;
            clientRequest.UserNickName = nickNameTextBox.Text;
            if (RequestControlService.ControlData(clientRequest))
            {
                ControlOrAddEntity(clientRequest);
                _ = ClientUtility.SendMessage(clientRequest);
            }
            MessageService messageService = new MessageService();
            Message message = new Message()
            {
                Content = clientRequest.Message,
                SenderUserName = clientRequest.UserNickName,
                RecipientUserName = clientRequest.ServerNickName
            };

            messageService.InsertMessage(message);
        }

        private void ControlOrAddEntity(ClientRequest clientRequest)
        {
            UserService userService = new UserService();
            userService.CreateUser(clientRequest.UserNickName);
        }
    }
}