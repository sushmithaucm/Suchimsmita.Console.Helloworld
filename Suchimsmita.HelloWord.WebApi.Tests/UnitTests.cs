using Microsoft.VisualStudio.TestTools.UnitTesting;
using Suchimsmita.HelloWord.WebApi.Controllers;

namespace Suchimsmita.HelloWord.WebApi.Tests
{
    [TestClass]
    public class ApiTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller= new ConsoleController();
            var message = controller.Get("world");
            Assert.AreEqual("Helloword",message);
        }
    }
}
