using Ansoft.Education.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Web.Mvc;

namespace Ansoft.Education.Web.Tests.Controllers
{
    
    
    /// <summary>
    ///这是 WebControllerTest 的测试类，旨在
    ///包含所有 WebControllerTest 单元测试
    ///</summary>
    [TestClass()]
    public class WebControllerTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        // 
        //编写测试时，还可使用以下特性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///WebController 构造函数 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\个人项目\\Ansoft.Education\\Ansoft.Education.Web", "/")]
        [UrlToTest("http://localhost:50843/")]
        public void WebControllerConstructorTest()
        {
            WebController target = new WebController();
            Assert.Inconclusive("TODO: 实现用来验证目标的代码");
        }

        /// <summary>
        ///BaiduMap 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\个人项目\\Ansoft.Education\\Ansoft.Education.Web", "/")]
        [UrlToTest("http://localhost:50843/")]
        public void BaiduMapTest()
        {
            WebController target = new WebController(); // TODO: 初始化为适当的值
            ActionResult expected = null; // TODO: 初始化为适当的值
            ActionResult actual;
            actual = target.BaiduMap();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Css 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\个人项目\\Ansoft.Education\\Ansoft.Education.Web", "/")]
        [UrlToTest("http://localhost:50843/")]
        public void CssTest()
        {
            WebController target = new WebController(); // TODO: 初始化为适当的值
            ActionResult expected = null; // TODO: 初始化为适当的值
            ActionResult actual;
            actual = target.Css();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///HighChart 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\个人项目\\Ansoft.Education\\Ansoft.Education.Web", "/")]
        [UrlToTest("http://localhost:50843/")]
        public void HighChartTest()
        {
            WebController target = new WebController(); // TODO: 初始化为适当的值
            ActionResult expected = null; // TODO: 初始化为适当的值
            ActionResult actual;
            actual = target.HighChart();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Html5 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\个人项目\\Ansoft.Education\\Ansoft.Education.Web", "/")]
        [UrlToTest("http://localhost:50843/")]
        public void Html5Test()
        {
            WebController target = new WebController(); // TODO: 初始化为适当的值
            ActionResult expected = null; // TODO: 初始化为适当的值
            ActionResult actual;
            actual = target.Html5();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Index 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\个人项目\\Ansoft.Education\\Ansoft.Education.Web", "/")]
        [UrlToTest("http://localhost:50843/")]
        public void IndexTest()
        {
            WebController target = new WebController(); // TODO: 初始化为适当的值
            ActionResult expected = null; // TODO: 初始化为适当的值
            ActionResult actual;
            actual = target.Index();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Js 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\个人项目\\Ansoft.Education\\Ansoft.Education.Web", "/")]
        [UrlToTest("http://localhost:50843/")]
        public void JsTest()
        {
            WebController target = new WebController(); // TODO: 初始化为适当的值
            ActionResult expected = null; // TODO: 初始化为适当的值
            ActionResult actual;
            actual = target.Js();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }
    }
}
