using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _mailCraftDomain.Interfaces.Global
{
    public interface INotifier
    {
        bool HasNotification();

        void ClearNotifications();

        List<Notify> GetNotifications();

        void Handle(Notify notification);
    }
}
