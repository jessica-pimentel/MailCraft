using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _mailCraftDomain.Notification
{
    public class Notify
    {
        public Notify(string message)
        {
            Message = message;
        }

        public string Message { get; }
    }
}
