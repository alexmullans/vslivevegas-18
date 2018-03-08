using ApiClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApiClientTestCore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WidgetClientTest()
        {
            var client = new WidgetClient();

            var widget = client.Get(6);
            Assert.AreEqual("Widget 6", widget);
        }
    }
}
