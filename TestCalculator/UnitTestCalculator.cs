namespace TestCalculator
{
    [TestClass]
    public class TestClassCalculator
    {
        
        [TestMethod]
        public void AddShouldReturnCorrectResult()
        {
            Assert.Equals(3.0, Calculator.Add(1.0, 2.0));
        }

        [TestMethod]
        public void SubtractShouldReturnCorrectResult()
        {
            Assert.Equals(-1.0, Calculator.Subtract(1.0, 2.0));
        }

        [TestMethod]
        public void MultiplyShouldReturnCorrectResult()
        {
            Assert.Equals(2.0, Calculator.Multiply(1.0, 2.0));
        }

        [TestMethod]
        public void DivideShouldReturnCorrectResult()
        {
            Assert.Equals(0.5, new Calculator.Divide(1.0, 2.0));
        }
    }

}
