using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ansoft.Education.EF;

namespace Ansoft.Education.Web.Models
{
    public class MenuModel : Ansoft.Education.EF.Menu
    {
        public List<Menu> Chirldren { get; set; }
    }
}