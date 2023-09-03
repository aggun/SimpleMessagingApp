using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMessagingApp.Data.Entity
{
    public class User
    {
        public string Nickname { get; set; }

        public ICollection<Message> SentMessages { get; set; }
    }
}
