using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaglevaniyBA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MaglevaniyBA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Богдан";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Богдан", res);
        }
    }
}
