using _mailCraftDomain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using _mailCraftDomain.Extensions;
using Microsoft.Extensions.Options;

namespace _mailCraftDomain.Service
{
    public class MailService : IMailService
    {
        private MailServiceSettings _mailSettings { get; }
        public MailService(IOptions<MailServiceSettings> mailSettings)
        {
            
        }
        public async Task<bool> Send(string subject, string boby, string attachment, string email, string? emailCopy, string from = "TESTE")
        {
            var attachments = new List<string> { attachment };

            return await Send(subject, boby, attachment, email, emailCopy, from);
        }

        public async Task<bool> SendFileEmailAsync(string recipientEmail, string subject, IEnumerable<Guid> simulationIds)
        {
            try
            {
                // Supondo que você possa obter os detalhes do pré-acordo aqui dentro do MailService
                var obj = new List<string>();
                obj.Add("Primeiro");
                obj.Add("Segundo");
                obj.Add("Terceiro");

                var values = (from _r in obj
                                          select new
                                          {
                                              Teste = "teste"
                                          }) ;

                var body = new StringBuilder();

                // Adicionando cabeçalho e informações gerais
                body.Append($@"<strong>{obj}</strong> Segue em anexo resumo do pré-TESTE
                            <br /><br />Data de realização: <strong>{obj}</strong><br />");

                // Adicionando detalhes específicos do pré-acordo
                body.Append("<strong>Dados Oferta:<br /></strong>");
                foreach (var simulationId in simulationIds)
                {
                    body.AppendLine("<br />");
                    body.AppendLine($"<strong style='font-size: 12px;'>Teste:</strong> {"teste"}<br />");
                    body.AppendLine("<br />");
                }

                // Adicionando rodapé
                body.Append(@"<br /><br /><br />Dúvidas acione o suporte (41) 9 xxxx-xxxx
                            <br /><br />E-mail automático, não responda para esse remetente</strong>
                            <br /><strong> TESTE CNPJ:XX.XX.XXX-XXXX</strong>");

                using (var mail = new MailMessage())
                {
                    mail.From = new MailAddress(_mailSettings.System.FromEmail, "TESTE", Encoding.UTF8);
                    mail.To.Add(new MailAddress(recipientEmail));
                    mail.Subject = subject;
                    mail.Body = body.ToString();
                    mail.IsBodyHtml = true;

                    // Anexar os arquivos gerados
                    var excelFilePath = "teste";
                    var pdfFilePath = "teste";
                    mail.Attachments.Add(new Attachment(excelFilePath));
                    mail.Attachments.Add(new Attachment(pdfFilePath));

                    using (var smtp = new SmtpClient(_mailSettings.System.STMP, _mailSettings.System.Port))
                    {
                        smtp.Credentials = new NetworkCredential(_mailSettings.System.UserName, _mailSettings.System.Password);
                        smtp.EnableSsl = _mailSettings.System.UseSSL;
                        await smtp.SendMailAsync(mail);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
