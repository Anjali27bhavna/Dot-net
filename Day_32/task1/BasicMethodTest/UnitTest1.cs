using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;


namespace BasicMethodTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFactorial()
        {
            int num = 5;
            int expectedfactorial = 120;
            BasicMaths obj = new BasicMaths();
            int actual=obj.factorial(num);
            Assert.AreEqual(actual, expectedfactorial);
        }
        [TestMethod]
        public void TestPrime()
        {
            int num = 17;
            bool expected = true;
            BasicMaths obj = new BasicMaths();
            bool actual = obj.prime(num);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestfactorialLessThanZero()
        {
            int num = -1;
            BasicMaths obj = new BasicMaths();
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => obj.factorial(num));
        }
        [TestMethod]
        public void TestprimeLessThanZero()
        {
            int num = -11;
            BasicMaths obj = new BasicMaths();
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => obj.prime(num));
        }





        //public void TestMethod1()
        //{
        //    BasicMaths bm = new BasicMaths();
        //    double res = bm.add(10, 10);
        //    Assert.AreEqual(res, 20);
        //}
        //[TestMethod]
        //public void TestMethod2()
        //{
        //    BasicMaths bm = new BasicMaths();
        //    double res = bm.subtract(10, 10);
        //    Assert.AreEqual(res, 0);
        //}
        //[TestMethod]
        //public void TestMethod3()
        //{
        //    BasicMaths bm = new BasicMaths();
        //    double res = bm.divide(10, 5);
        //    Assert.AreEqual(res, 2);
        //}
        //[TestMethod]
        //public void TestMethod4()
        //{
        //    BasicMaths bm = new BasicMaths();
        //    double res = bm.multiply(10, 10);
        //    Assert.AreEqual(res, 100);
        //}
    }
    
}
