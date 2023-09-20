using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoFDS.Models
{
    public class CarritoCompraModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, 
                                ModelBindingContext bindingContext)
        {
            CarritoCompra cc = 
            (CarritoCompra)controllerContext.HttpContext.Session["CC_123"];

            if (cc==null)
            {
                cc = new CarritoCompra();
                controllerContext.HttpContext.Session["CC_123"] = cc;
            }

            return cc;
        }
    }
}