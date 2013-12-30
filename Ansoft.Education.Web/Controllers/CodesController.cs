using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ansoft.Education.EF;
using System.Web.Routing;

namespace Ansoft.Education.Web.Controllers
{
    public class CodesController : Controller
    {
        //
        // GET: /Codes/



        public ActionResult List()
        {

            #region 绑定类别
            List<Module> moduleList = null;
            using (AnsoftEntities context = new AnsoftEntities())
            {
                moduleList = (from m in context.Module
                              orderby m.SortIndex ascending
                              select m).ToList();

            }
            if (moduleList == null)
                return View();

            List<SelectListItem> selItems = new List<SelectListItem>();

            //选择全部
            SelectListItem allItem = new SelectListItem();
            allItem.Value = "0";
            allItem.Text = "ALL";
            //allItem.Selected = true;
            selItems.Add(allItem);
            foreach (var module in moduleList)
            {
                SelectListItem selItem = new SelectListItem();
                selItem.Value = module.ID.ToString();
                selItem.Text = module.Name;
                selItems.Add(selItem);
            }
            #endregion

            List<EF.Codes> codesList = null;
            using (AnsoftEntities context = new AnsoftEntities())
            {
                //id表示Code Module
                //RouteData.Values["id"]
                if (Request["Module"] == null)
                {
                    codesList = (from c in context.Codes
                                 join m in context.Module
                                 on c.ModuleId equals m.ID
                                 select c).ToList();
                }
                else
                {
                    int moduleIdResult = 0;
                    if (int.TryParse(Request["Module"].ToString(), out moduleIdResult) == true)
                    {
                        //定位选择控件项
                        foreach (var sel in selItems)
                        {
                            if (sel.Value == moduleIdResult.ToString())
                            {
                                sel.Selected = true;
                            }
                        }

                        if (moduleIdResult == 0)
                        {
                            codesList = (from c in context.Codes
                                         join m in context.Module
                                         on c.ModuleId equals m.ID
                                         select c).ToList();
                        }
                        else
                        {
                            codesList = (from c in context.Codes
                                         join m in context.Module
                                         on c.ModuleId equals m.ID
                                         where m.ID == moduleIdResult
                                         select c).ToList();
                        }
                    }
                }
            }

            //传送到页面层
            ViewBag.selItems = selItems;

            return View(codesList);
        }

        public ActionResult Add()
        {
            List<Module> moduleList = null;
            using (AnsoftEntities context = new AnsoftEntities())
            {
                moduleList = (from m in context.Module
                              orderby m.SortIndex ascending
                              select m).ToList();

            }
            if (moduleList == null)
                return View();

            List<SelectListItem> selItems = new List<SelectListItem>();
            foreach (var module in moduleList)
            {
                SelectListItem selItem = new SelectListItem();
                selItem.Value = module.ID.ToString();
                selItem.Text = module.Name;
                if (module.Name == "Python")
                {
                    selItem.Selected = true;
                }
                selItems.Add(selItem);
            }

            //传送到页面层
            ViewBag.selItems = selItems;

            return View();
        }

        public ActionResult Python()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult AddOperation()
        {
            EF.Codes code = new EF.Codes();
            code.ModuleId = Convert.ToInt32(Request["Module"]);
            code.Name = Request["Name"].ToString();
            code.Author = Request["Author"].ToString();
            code.CreateTime = DateTime.Now;
            code.Descript = Request["Descript"].ToString();
            code.Code = Request["CodeEditor"].ToString();

            using (Ansoft.Education.EF.AnsoftEntities context = new AnsoftEntities())
            {
                context.Codes.AddObject(code);

                context.SaveChanges();
            }

            return RedirectToAction("List", "Codes", new RouteValueDictionary { {"id",code.ModuleId}});
        }

        public ActionResult ViewCode()
        {
            return View();
        }

        public ActionResult EditCode()
        {
            return View();
        }

    }
}
