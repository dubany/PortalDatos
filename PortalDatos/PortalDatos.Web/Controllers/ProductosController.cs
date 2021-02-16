using PortalDatos.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalDatos.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto1 = new ProductoModel();
            producto1.Id = 1;
            producto1.Descripcion = "Storages";

            var producto2 = new ProductoModel();
            producto2.Id = 2;
            producto2.Descripcion = "Switches";

            var producto3 = new ProductoModel();
            producto3.Id = 3;
            producto3.Descripcion = "Librerias";

            var ListadeProductos = new List<ProductoModel>();
            ListadeProductos.Add(producto1);
            ListadeProductos.Add(producto2);
            ListadeProductos.Add(producto3);


            return View(ListadeProductos);
        }
    }
}