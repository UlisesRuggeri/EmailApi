using Microsoft.AspNetCore.Mvc;
using EnvioCorreo.Interfaces;
using EnvioCorreo.Models;

namespace EnvioCorreo.Controllers;

[Route("api/emails")]
[ApiController]
public class EmailsController : ControllerBase
{
    private readonly IEmailService _service;

    public EmailsController(IEmailService service) => _service = service;


    [HttpPost]
    public async Task<IActionResult> Enviar([FromBody] EmailDto dto)
    {
        await _service.EnviarEmail(dto);
        return Ok("Correo enviado correctamente.");
    }

    [HttpGet]
    public IActionResult Test()
    {
        return Ok("los endpoint funcionan");
    }

}
