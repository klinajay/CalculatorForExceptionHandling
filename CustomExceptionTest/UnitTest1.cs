
using CalculatorForExceptionHandling;
namespace CustomExceptionTest
{
    public class UnitTest1
    {
        [Fact]
        public void OperationNotValidExceptionTest()
        {
            var calculator = new Calculator(1,1,"2");
            Assert.Throws<OperationNotValidException>(() => calculator.Calculate());
        }
    }
}