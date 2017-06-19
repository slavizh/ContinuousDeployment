using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContinuousWeb.Controllers;

namespace ContiniousWeb.Tests
{
    [TestClass]
    public class HomeControlelrTests
    {
        [TestMethod]
        public void AboutPageTest()
        {
            var homeController = new HomeController();
            var result = homeController.About();
        }
    }
}
