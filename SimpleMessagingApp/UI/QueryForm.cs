using SimpleMessagingApp.Business;
using SimpleMessagingApp.Data.Entity;
using Message = SimpleMessagingApp.Data.Entity.Message;

namespace SimpleMessagingApp.UI
{
    public partial class QueryForm : Form
    {
        ServerService serverService;
        UserService userService;
        MessageService messageService;

        public QueryForm()
        {
            InitializeComponent();
            serverService = new ServerService();
            userService = new UserService();
            messageService = new MessageService();
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            serverNameComboBox.DataSource = userService.GetAll();
            clientNameComboBox.DataSource = serverService.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = messageService.GetLastMessagesByUserId(serverNameComboBox.SelectedItem.ToString(), Convert.ToInt32(lastMessagesCountNumericUpDown.Value));

            dataGridView1.DataSource = FilterData(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = messageService.GetLastMessagesByServerId(clientNameComboBox.SelectedItem.ToString(), Convert.ToInt32(lastMessagesCountNumericUpDown.Value));

            dataGridView1.DataSource = FilterData(result);
        }

        private List<Message> FilterData(List<Message> messages)
        {
            if (string.IsNullOrWhiteSpace(containsMessageTextBox.Text))
            {
                return messages.Where(x => x.Content.Contains(containsMessageTextBox.Text.ToString())).ToList();
            }
            return messages;
        }

    }
}

