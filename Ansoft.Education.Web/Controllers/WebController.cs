using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ansoft.Education.EF;


namespace Ansoft.Education.Web.Controllers
{
    public class WebController : Controller
    {
        //
        // GET: /Web/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Html5()
        {
            //PyService.PyServiceClient pyServiceEntity = new PyServiceClient("pyservice");
            //var rs = pyServiceEntity.SayHi();
            ViewBag.PyHi = "Damn it.Bug";
            return View();
        }

        public ActionResult Js()
        {
            return View();
        }

        public ActionResult Css()
        {
            return View();
        }

        public ActionResult BaiduMap()
        {
            return View();
        }

        public ActionResult HighChart()
        {
            return View();
        }

        public ActionResult TextEditor()
        {
            return View();
        }

        public ActionResult ViewCode()
        {
            using (AnsoftEntities entity = new AnsoftEntities())
            {
                Module codeType = new Module();
                codeType.Name = "C#";
                entity.Module.AddObject(codeType);
                //entity.AddToSourceCodeType(codeType);
                //entity.SaveChanges();
            }
            return View();
        }

        private readonly List<Client> clients = new List<Client>()
    {
        new Client { Id = 1, Name = "Julio Avellaneda", Email = "julito_gtu@hotmail.com" },
        new Client { Id = 2, Name = "Juan Torres", Email = "jtorres@hotmail.com" },
        new Client { Id = 3, Name = "Oscar Camacho", Email = "oscar@hotmail.com" },
        new Client { Id = 4, Name = "Gina Urrego", Email = "ginna@hotmail.com" },
        new Client { Id = 5, Name = "Nathalia Ramirez", Email = "natha@hotmail.com" },
        new Client { Id = 6, Name = "Raul Rodriguez", Email = "rodriguez.raul@hotmail.com" },
        new Client { Id = 7, Name = "Johana Espitia", Email = "johana_espitia@hotmail.com" }
    };


        public ActionResult Grid()
        {
            return View(clients);
        }

    }

    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
