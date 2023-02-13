using LandingPage.Models;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace LandingPage.Servicios
{
    public interface IServicioEmail
    {
        Task Enviar(ContactoViewModel contacto);
    }

    public class ServicioEmailSendGrid : IServicioEmail
    {
        private readonly IConfiguration configuration;

        public ServicioEmailSendGrid(IConfiguration configuration)
        {
            this.configuration = configuration;
            DotNetEnv.Env.Load();
        }

        public async Task Enviar(ContactoViewModel contacto)
        {
            var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
            var email = Environment.GetEnvironmentVariable("SENDGRID_FROM");
            var nombre = Environment.GetEnvironmentVariable("SENDGRID_NOMBRE");

            //var apiKey = configuration["SENDGRID_API_KEY"];
            //var email = configuration["SENDGRID_FROM"];
            //var nombre = configuration["SENDGRID_NOMBRE"];

            var cliente = new SendGridClient(apiKey);
            var from = new EmailAddress(email, nombre);
            var subject = $"El cliente {contacto.Email} quiere contactarte";
            var to = new EmailAddress(email, nombre);
            var mensajeTextoPlano = contacto.Mensaje;
            var contenidoHtml = @$"De: {contacto.Nombre} -
Email: {contacto.Email}
Mensaje: {contacto.Mensaje}";
            var singleEmail = MailHelper.CreateSingleEmail(from, to, subject,
                mensajeTextoPlano, contenidoHtml);
            var respuesta = await cliente.SendEmailAsync(singleEmail);
        }
    }
}
