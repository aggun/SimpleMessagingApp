using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMessagingApp.Data.Entity
{
    public class Server
    {
        public string Nickname { get; set; }

        public ICollection<Message> ReceivedMessages { get; set; }
    }
}
