using LandingPage.Models;

namespace LandingPage.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }

    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
            {
                new Proyecto
                {
                    Titulo = "Portfolio en Angular",
                    Descripcion = "Landging page personal realizado en Angular",
                    Link = "https://emmanuel-zelarayan-dev.web.app/",
                    ImagenUrl= "/imagenes/portangular.png"
                },
                new Proyecto
                {
                    Titulo = "Sala de Juegos",
                    Descripcion = "Página con 4 minijuegos",
                    Link = "https://fir-userauth-fe03f.web.app/",
                    ImagenUrl= "/imagenes/saladejuegos.png"
                },
                new Proyecto
                {
                    Titulo = "Clínica Online",
                    Descripcion = "Página que simula la gestión de una clínica",
                    Link = "https://clinica-online-tp2-labo-iv.firebaseapp.com/",
                    ImagenUrl= "/imagenes/clinica.png"
                },
                new Proyecto
                {
                    Titulo = "Rick and Morty",
                    Descripcion = "Juego de Memoria con Cartas",
                    Link = "https://rickandmortycardgame.000webhostapp.com/index.php",
                    ImagenUrl= "/imagenes/rym.png"
                },
                new Proyecto
                {
                    Titulo = "Peluquería Lilian",
                    Descripcion = "Landing page de Peluquería Lilian",
                    Link = "https://lilian.ar/",
                    ImagenUrl= "/imagenes/peluqueriaLanding.png"
                },
                new Proyecto
                {
                    Titulo = "Peluquería Lilian Clientes",
                    Descripcion = "Gestión de Clientes de Peluquería Lilian",
                    Link = "https://lilian-clientes.onrender.com/",
                    ImagenUrl= "/imagenes/lilianclientes.png"
                },
                new Proyecto
                {
                    Titulo = "Punto de Venta",
                    Descripcion = "Punto de Venta simple",
                    Link = "https://github.com/EmmaVZ89/Punto-de-Venta-.NET",
                    ImagenUrl= "/imagenes/pos.png"
                },
                new Proyecto
                {
                    Titulo = "Relevamiento Visual",
                    Descripcion = "Aplicación móvil para la recopilación de datos visuales",
                    Link = "https://github.com/EmmaVZ89/Relevamiento-Visual-PPS",
                    ImagenUrl= "/imagenes/rv.png"
                },
                new Proyecto
                {
                    Titulo = "Tabla Didáctica",
                    Descripcion = "Aplicación movil para el uso de niños de  aprox 5 años",
                    Link = "https://github.com/EmmaVZ89/Tabla-Didactica-PPS",
                    ImagenUrl= "/imagenes/tdi.png"
                },
                new Proyecto
                {
                    Titulo = "Alarma de Robo",
                    Descripcion = "Aplicación móvil para la seguridad de nuestro dispositivo",
                    Link = "https://github.com/EmmaVZ89/Alarma-de-Robo-PPS",
                    ImagenUrl= "/imagenes/ar.png"
                },
                new Proyecto
                {
                    Titulo = "Carga de Crédito",
                    Descripcion = "Aplicación móvil que simula la carga de crédito a través de QRs",
                    Link = "https://github.com/EmmaVZ89/Carga-de-Credito-PPS",
                    ImagenUrl= "/imagenes/cc.png"
                },
                new Proyecto
                {
                    Titulo = "Conversando en el Aula",
                    Descripcion = "Aplicación móvil para la comunicación a través de 2 salas de chats",
                    Link = "https://github.com/EmmaVZ89/Conversando-en-el-Aula-PPS",
                    ImagenUrl= "/imagenes/ca.png"
                },
                new Proyecto
                {
                    Titulo = "Administración de Usuarios",
                    Descripcion = "Aplicación móvil para la gestión de usuarios",
                    Link = "https://github.com/EmmaVZ89/Administracion-de-Usuarios-PPS",
                    ImagenUrl= "/imagenes/au.png"
                },
                 new Proyecto
                {
                    Titulo = "Despertador por GPS",
                    Descripcion = "Aplicación móvil usada como despertador utilizando la ubicación del usuario",
                    Link = "https://github.com/EmmaVZ89/Despertador-por-GPS-PPS",
                    ImagenUrl= "/imagenes/dgps.png"
                },
                new Proyecto
                {
                    Titulo = "Visualizador Kinético",
                    Descripcion = "Aplicación móvil para la visualización de datos con el acelerometro",
                    Link = "https://github.com/EmmaVZ89/Visualizador-Kinetico-PPS",
                    ImagenUrl= "/imagenes/vk.png"
                },
                new Proyecto
                {
                    Titulo = "Juego Kinético",
                    Descripcion = "Juego móvil utilizando el acelerometro del dispositivo",
                    Link = "https://emmanuel-zelarayan-dev.web.app/",
                    ImagenUrl= "/imagenes/jk.png"
                },
                new Proyecto
                {
                    Titulo = "Control de Gastos",
                    Descripcion = "Aplicación móvil para gestionar gastos",
                    Link = "https://github.com/EmmaVZ89/Control-de-Gastos-PPS",
                    ImagenUrl= "/imagenes/cg.png"
                }
            };
        }

    }
}
