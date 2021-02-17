using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalDatos.BL
{
    public class ProductosBL
    {
        public List<Producto> OctenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Storages";
            producto1.Precio = 500;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Switches";
            producto2.Precio = 650;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Librerias";
            producto3.Precio = 800;

            var ListadeProductos = new List<Producto>();
            ListadeProductos.Add(producto1);
            ListadeProductos.Add(producto2);
            ListadeProductos.Add(producto3);

            return ListadeProductos;
        }
    }
}
