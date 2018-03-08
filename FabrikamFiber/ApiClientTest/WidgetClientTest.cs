using System;
using ApiClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApiClientTest
{
    [TestClass]
    public class WidgetClientTest
    {
        [TestMethod]
        public void WidgetClientTest1()
        {
            var client = new WidgetClient();

            var widget = client.Get(6);
            Assert.AreEqual("Widget 6", widget);
        }
    }
}
