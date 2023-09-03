namespace SimpleMessagingApp.Data.Entity
{
    public class Message
    {
        public DateTime InsertDateTime { get; set; }
        public int MessageId { get; set; }
        public string Content { get; set; }

        public string SenderUserName { get; set; }
        public User SenderUser { get; set; }

        public string RecipientUserName { get; set; }
        public Server RecipientUser { get; set; }
    }
}
