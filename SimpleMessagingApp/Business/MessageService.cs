using SimpleMessagingApp.Data.Context;
using SimpleMessagingApp.Data.Entity;
using SimpleMessagingApp.Data.Service;
using Message = SimpleMessagingApp.Data.Entity.Message;

namespace SimpleMessagingApp.Business
{
    public class MessageService
    {
        MessagingDbContext dbContext;
        BaseService<Message> messageService;
        BaseService<User> userService;
        BaseService<Server> serverService;

        public MessageService()
        {
            this.dbContext = new MessagingDbContext();
            this.messageService = new BaseService<Message>(dbContext);
            this.userService = new BaseService<User>(dbContext);
            this.serverService = new BaseService<Server>(dbContext);
        }
        public void InsertMessage(Message messageRequest)
        {
            var user = userService.GetById(messageRequest.SenderUserName);
            var server = serverService.GetById(messageRequest.RecipientUserName);
            Message message = new Message()
            {
                Content = messageRequest.Content,
                SenderUser = user,
                SenderUserName = messageRequest.SenderUserName,
                RecipientUser = server,
                RecipientUserName = messageRequest.RecipientUserName,
                InsertDateTime = DateTime.Now
            };
            _ = messageService.Add(message);
        }

        public List<Message> GetLastMessagesByUserId(string nickName, int takeMessagesCount)
        {
            var result = messageService.GetAllByFiltered(x => x.SenderUserName == nickName)
                                       .OrderByDescending(x => x.InsertDateTime).ToList();

            return GetMessagesByTakeCount(result, takeMessagesCount);
        }

        public List<Message> GetLastMessagesByServerId(string nickName, int takeMessagesCount)
        {
            var result = messageService.GetAllByFiltered(x => x.RecipientUserName == nickName)
                                       .OrderByDescending(x => x.InsertDateTime).Take(10).ToList();

            return GetMessagesByTakeCount(result, takeMessagesCount);
        }

        private List<Message> GetMessagesByTakeCount(List<Message> messages, int? takeMessagesCount)
        {
            if ((takeMessagesCount ?? 0) == 0)
            {
                return messages;
            }
            return messages.Take(takeMessagesCount.Value).ToList();
        }
    }
}
