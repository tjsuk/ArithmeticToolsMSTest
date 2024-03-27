using ArithmeticTools;

namespace CalcTest
{
    [TestClass]
    public class CalcTests
    {
        Calc calc = new Calc();

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(4, calc.Add(2, 2));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(5, calc.Add(2, 3));
        }

    }
}