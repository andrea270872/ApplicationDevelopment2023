using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDrivenDev_example1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Add(10, 10);
            Assert.AreEqual(res, 20);
        }
        [TestMethod]
        public void Test_SubstractMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Substract(10, 10);
            Assert.AreEqual(res, 0);
        }
        [TestMethod]
        public void Test_DivideMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.divide(10, 5);
            Assert.AreEqual(res, 2);
        }
        [TestMethod]
        public void Test_MultiplyMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Multiply(10, 10);
            Assert.AreEqual(res, 100);
        }
    }

    // my second test class ... ---------------------
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Test_AdditionSymmetric()
        {
            BasicMaths bm = new BasicMaths();
            BasicMaths bm2 = new BasicMaths();
            double res1 = bm.Add(2,3);
            double res2 = bm2.Add(3,2);
            Assert.AreEqual(res1, res2); // addition is symmetric
        }
    }
}