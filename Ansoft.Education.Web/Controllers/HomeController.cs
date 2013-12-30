using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ansoft.Education.Web.Models;
using Ansoft.Education.EF;

namespace Ansoft.Education.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public PartialViewResult _Menu()
        {
            List<MenuModel> pageMenus = new List<MenuModel>(); //最终绑定到页面上的
            List<Menu> parentMenus = null;
            using (AnsoftEntities context = new AnsoftEntities())
            {
                parentMenus = (from m in context.Menu
                               where m.LevelCount == 2
                               orderby m.SortIndex ascending
                               select m).ToList();
            }
            //如果没有任何数据那么美就返回咯
            if (parentMenus == null)
            {
                return null;
            }
            //通过父级项目再去查询子级项目
            foreach (var itemParent in parentMenus)
            {
                MenuModel menu = new MenuModel();
                menu.ID = itemParent.ID;
                menu.Action = itemParent.Action;
                menu.Controller = itemParent.Controller;
                menu.Text = itemParent.Text;
                List<Menu> menuChildren = null;
                using (Ansoft.Education.EF.AnsoftEntities context = new AnsoftEntities())
                {
                    //查找子菜单
                   menuChildren = (from m in context.Menu
                                                    where m.ParentId == itemParent.ID
                                                    orderby m.SortIndex ascending
                                                    select m).ToList();
                }
                if (menuChildren != null && menuChildren.Count != 0)
                {
                    menu.Chirldren = menuChildren;
                }

                pageMenus.Add(menu);
            }

            return PartialView(pageMenus);

        }
    }
}
