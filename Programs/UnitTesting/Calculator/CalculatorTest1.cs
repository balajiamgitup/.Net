
namespace Calculator.nUnitTests
{
    public class CalculatorTest1
    {
        private cal.Calculator _calculator { get; set; } = null;
        [SetUp]
        public void Setup()
        {
           _calculator = new cal.Calculator();
        }

        [TestCase(2,3,5)]
        [TestCase(3,4,7)]
        public void add_Test(int x,int y,int z)
        {
         
            var result = _calculator.add(x, y);

            Assert.AreEqual(z,result);
        }
        [TestCase(2, 3, 6)]
        [TestCase(3, 4, 12)]
        public void mul_Test(int x, int y, int z)
        {

            var result = _calculator.mul(x, y);

            Assert.AreEqual(z, result);
        }
        [TestCase(9, 3, 3)]
        [TestCase(12, 4, 3)]
        public void div_Test(int x, int y, int z)
        {

            var result = _calculator.div(x, y);

            Assert.AreEqual(z, result);
        }
    }
}