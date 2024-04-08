# API de Configuração e Criação de Mail

Essa API é responsável por gerenciar configurações e criar mail. Ela oferece funcionalidades para configurar parâmetros específicos e gerar arquivos como anexo de mail com base nessas configurações.

## Funcionalidades

- **Configuração Dinâmica:** Permite configurar diversos aspectos do processo de geração de arquivos para anexo de mail, como formatação, estilos, campos obrigatórios, entre outros.
- **Endpoint RESTful:** Oferece uma interface RESTful para interação com a API, permitindo integração fácil com outros sistemas.

## Pacotes Utilizados para Mail 

- **System.Net.Mail**: Namespace que fornece classes para enviar e-mails através do protocolo SMTP (Simple Mail Transfer Protocol), incluindo `MailMessage` para representar um e-mail, `SmtpClient` para enviar e-mails e `Attachment` para lidar com anexos.
- **System.Net**: Namespace que fornece classes para trabalhar com redes em geral, incluindo `NetworkCredential` para fornecer credenciais de autenticação para o servidor SMTP.
- **System.Text**: Namespace usado para manipular codificações de texto, e é usado no código fornecido para especificar a codificação UTF-8 ao definir o remetente do e-mail.
