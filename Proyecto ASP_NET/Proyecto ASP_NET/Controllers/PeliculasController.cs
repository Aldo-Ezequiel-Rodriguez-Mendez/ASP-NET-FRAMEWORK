using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_ASP_NET.Models;
using Proyecto_ASP_NET.ViewModels;

namespace Proyecto_ASP_NET.Controllers
{
    public class PeliculasController : Controller
    {
        // GET: Peliculas
        public ActionResult Random()
        {
            var pelicula = new Pelicula() { Nombre = "Sherk!" };

            var Clientes = new List<Cliente>
            {
                new Cliente {Nombre = "Empleado 1"},
                new Cliente {Nombre = "Empleado 2"}
            };

            var viewModel = new RandomPeliculaViewModel
            {
                Pelicula = pelicula,
                Clientes = Clientes
            };
            return View(viewModel);
        }

        public ActionResult Editar(int peliculaID)
        {
            return Content("id = "  + peliculaID);
        }

        public ActionResult Index(int? pageIndex,string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("PageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        //Agregando la ruta
        //Se puede usar otras restricciones (constraints) min, max, minlength, maxlength, int, float, guid
        //Para mas restricciones se puede buscar en google "ASP.NET MV Attribute Route Constraints"
        [Route("peliculas/lanzamiento/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult PorLanzamiento(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}