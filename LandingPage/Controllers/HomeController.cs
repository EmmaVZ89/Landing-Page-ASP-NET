using LandingPage.Models;
using LandingPage.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LandingPage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos repositorioProyectos;
        private readonly IServicioEmail servicioEmail;

        public HomeController(ILogger<HomeController> logger, 
            IRepositorioProyectos repositorioProyectos,
            IServicioEmail servicioEmail)
        {
            this._logger = logger;
            this.repositorioProyectos = repositorioProyectos;
            this.servicioEmail = servicioEmail;
        }

        public IActionResult Index()
        {
            //_logger.LogInformation("Este es un mensaje de log");
            //_logger.LogCritical("Soy critical");
            //_logger.LogDebug("Soy debug");
            //_logger.LogTrace("Soy trace");
            //_logger.LogError("Soy error");
            //_logger.LogWarning("Soy warning");
            var proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
        }
        
        public IActionResult Proyectos()
        {
            var proyectos = repositorioProyectos.ObtenerProyectos();
            return View(proyectos);
        }

        [HttpGet]
        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contacto(ContactoViewModel contactoViewModel)
        {
            await servicioEmail.Enviar(contactoViewModel);
            return RedirectToAction("Agradecimiento");
        }

        public IActionResult Agradecimiento()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}