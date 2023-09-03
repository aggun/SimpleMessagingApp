using SimpleMessagingApp.Data.Context;
using SimpleMessagingApp.Data.Entity;
using SimpleMessagingApp.Data.Service;

namespace SimpleMessagingApp.Business
{
    public class ServerService
    {
        MessagingDbContext dbContext;
        BaseService<Server> serverService;

        public ServerService()
        {
            this.dbContext = new MessagingDbContext();
            this.serverService = new BaseService<Server>(dbContext);
        }

        public void CreateServer(string nickname)
        {
            Server? server;
            server = serverService.GetById(nickname);
            if (server == null)
            {
                Server newServer = new Server()
                {
                    Nickname = nickname,
                };
                serverService.Add(newServer);
            }
        }

        public List<Server> GetAll()
        {
            var result = serverService.GetAll().ToList();
            return result;
        }
    }
}