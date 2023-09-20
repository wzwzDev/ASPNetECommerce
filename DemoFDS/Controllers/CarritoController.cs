using DemoFDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoFDS.Controllers
{
    [Authorize]
    public class CarritoController : Controller
    {
        ModeloTiendaContainer con = new ModeloTiendaContainer();

        public ActionResult Confirm(CarritoCompra cc)
        {
            Pedido pedido = new Pedido();
            foreach(Producto p in cc)
            {                               
                ProductoComprado pc = new ProductoComprado();
                pc.Producto = con.Productos.Find(p.Id);
                pedido.ProductoCompradoes.Add(pc);                
            }
            con.Pedidos.Add(pedido);
            Cliente cliente = con.Clientes
                .Where(x => x.Email.Equals(User.Identity.Name)).First();
            pedido.Cliente = cliente;
            con.SaveChanges();
            cc.Clear();
            return RedirectToAction("Index", "Productos");
        }


        // GET: Carrito
        public ActionResult Index(CarritoCompra cc)
        {
            return View(cc);
        }


        public ActionResult Add(CarritoCompra cc, int id)
        {
            Producto p = con.Productos.Find(id);
            cc.Add(p);

            return RedirectToAction ("Index","Productos");
        }
    }
}