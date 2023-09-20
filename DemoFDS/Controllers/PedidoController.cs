using DemoFDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoFDS.Controllers
{
    public class PedidoController : Controller
    {
        // GET: Pedido
        private ModeloTiendaContainer con = new ModeloTiendaContainer();
        public ActionResult Index()
        {
            return View(con.Pedidos.ToList());
        }
    }
}