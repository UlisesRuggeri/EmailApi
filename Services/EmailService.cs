using EnvioCorreo.Interfaces;
using EnvioCorreo.Models;
using Resend;

namespace EnvioCorreo.Services;

public class EmailService : IEmailService
{
    private readonly IResend _resend;

    public EmailService(IConfiguration config)
    {
        var apiKey = config.GetValue<string>("Resend:ApiKey");
        _resend = ResendClient.Create(apiKey!);
    }

    public async Task EnviarEmail(EmailDto dto)
    {
        var email = new EmailMessage()
        {
            From = "onboarding@resend.dev",
            To = "ruggeriulises2@gmail.com",
            Subject = dto.Tema,
            HtmlBody = $"<p>{dto.Cuerpo}</p>"
        };

        await _resend.EmailSendAsync(email);
    }
}
