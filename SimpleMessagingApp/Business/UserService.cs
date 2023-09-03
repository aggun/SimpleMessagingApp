using SimpleMessagingApp.Data.Context;
using SimpleMessagingApp.Data.Entity;
using SimpleMessagingApp.Data.Service;

namespace SimpleMessagingApp.Business
{
    public class UserService
    {
        MessagingDbContext dbContext;
        BaseService<User> userService;

        public UserService()
        {
            this.dbContext = new MessagingDbContext();
            this.userService = new BaseService<User>(dbContext);
        }

        public void CreateUser(string nickname)
        {
            User? user;
            user = userService.GetById(nickname);
            if (user == null)
            {
                User newUser = new User()
                {
                    Nickname = nickname,
                };
                userService.Add(newUser);
            }
        }
        public List<User> GetAll()
        {
            var result = userService.GetAll().ToList();
            return result;
        }

    }
}
