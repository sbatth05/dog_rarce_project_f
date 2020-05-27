using System;
using dog_rarce_project_f;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dog_rarce_project_fTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Form1 obj = new Form1();
            obj.resetAll();
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GroundMethod1()
        {
            Ground obj = new Ground();
            int x = 720;
            if (x == obj.endPoint())
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }

        }

    }
}
