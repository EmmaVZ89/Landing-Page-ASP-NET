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
                    Titulo = "Amazon",
                    Descripcion = "E-Commerce realizado en ASP.NET Core",
                    Link = "https://amazon.com",
                    ImagenUrl= "/imagenes/repositorio.jpeg"
                },
                new Proyecto
                {
                    Titulo = "New York Times",
                    Descripcion = "Página de noticias en React",
                    Link = "https://amazon.com",
                    ImagenUrl= "/imagenes/repositorio.jpeg"
                },
                new Proyecto
                {
                    Titulo = "Reddit",
                    Descripcion = "Red social para compartir en comunidades",
                    Link = "https://amazon.com",
                    ImagenUrl= "/imagenes/repositorio.jpeg"
                },
                new Proyecto
                {
                    Titulo = "Steam",
                    Descripcion = "Tienda en línea para comprar videojuegos",
                    Link = "https://amazon.com",
                    ImagenUrl= "/imagenes/repositorio.jpeg"
                }
            };
        }

    }
}
