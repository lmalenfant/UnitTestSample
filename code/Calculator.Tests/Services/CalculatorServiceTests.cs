using Calculator.Services;

namespace Calculator.Tests.Services
{
    [TestClass]
    public class CalculatorServiceTests
    {
        private static CalculatorService? _calculatorService;

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            _ = context;
            _calculatorService = new CalculatorService();
        }

        [TestMethod]
        public void Test_adding_two_numbers()
        {
            Assert.IsNotNull(_calculatorService);
            var total = _calculatorService.Add(3, 4);
            Assert.AreEqual(7, total);
        }

        [TestMethod]
        public void Test_adding_3_numbers()
        {
            Assert.IsNotNull(_calculatorService);
            var total = _calculatorService.Add(2, 5, 7);
            Assert.AreEqual(14, total);
        }

        [TestMethod]
        public void Test_adding_3_doubles()
        {
            Assert.IsNotNull(_calculatorService);
            var total = _calculatorService.Add(2.5, 6.25);
            Assert.AreEqual(8.75, total);
        }

        [TestMethod]
        public void Test_divide()
        {
            Assert.IsNotNull(_calculatorService);
            var result = _calculatorService.Divide(15, 3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_divide_throws_error()
        {
            Assert.IsNotNull(_calculatorService);
            _calculatorService.Divide(15, 0);
        }

        [TestMethod]
        public void Test_divide_throws_error_message()
        {
            Assert.IsNotNull(_calculatorService);
            Assert.ThrowsException<ArgumentException>(() =>
            {
                try
                {
                    _calculatorService.Divide(2, 0);
                }
                catch (ArgumentException e)
                {
                    Assert.AreEqual("The divisor cannot be zero", e.Message);
                    throw;
                }
            });
        }
    }
}
