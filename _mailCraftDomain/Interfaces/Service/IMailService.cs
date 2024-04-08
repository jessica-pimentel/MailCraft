using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _mailCraftDomain.Interfaces.Service
{
    public interface IMailService
    {
        Task<bool> Send(string subject, string? boby, string attachment, string email, string? emailCopy, string from = "TESTE");
        Task<bool> SendFileEmailAsync(string recipientEmail, string subject, IEnumerable<Guid> Ids);
    }
}
