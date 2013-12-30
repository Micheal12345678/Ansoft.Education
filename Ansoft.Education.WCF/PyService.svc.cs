using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Ansoft.Education.WCF
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“PySerice”。
    public class PyService : IPyService
    {
        string IPyService.SayHi()
        {
            return "Hi";
        }
    }
}
