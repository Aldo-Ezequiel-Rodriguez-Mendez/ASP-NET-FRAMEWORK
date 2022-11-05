using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto_ASP_NET.Models;

namespace Proyecto_ASP_NET.ViewModels
{
    public class RandomPeliculaViewModel
    {
        public Pelicula Pelicula { get; set; }
        public List<Cliente> Clientes { get; set; }
    }
}