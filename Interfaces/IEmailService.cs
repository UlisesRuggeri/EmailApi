using EnvioCorreo.Models;

namespace EnvioCorreo.Interfaces;

public interface IEmailService
{
    Task EnviarEmail(EmailDto dto);
}
