using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using Ansoft.Education.EF;

namespace Ansoft.Education.Web.AsyncService
{
    /// <summary>
    /// CodesService 的摘要说明
    /// </summary>
    public class CodesService : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            if (context.Request["method"] != null)
            {
                //获取要执行的方法名称
                string methodName = context.Request["method"].ToString();
                //反射执行指定的方法
                MethodInfo mi = this.GetType().GetMethod(methodName);
                if (mi != null)
                {
                    mi.Invoke(this, new object[] { context });
                }
            }
        }

        public void DelCodeById(HttpContext context)
        {
            if (context.Request["CodeId"]==null) {
                return;
            }
            int codeId = Convert.ToInt32(context.Request["CodeId"].ToString());
            using (Ansoft.Education.EF.AnsoftEntities DBContext = new Ansoft.Education.EF.AnsoftEntities())
            {
                Codes codeEntity = (from c in DBContext.Codes
                                    where c.ID == codeId
                                    select c).FirstOrDefault();
                if (codeEntity != null)
                {
                    DBContext.DeleteObject(codeEntity);
                    DBContext.SaveChanges();
                }
            }
            context.Response.Write("Delete OK");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}