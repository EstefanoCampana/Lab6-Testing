using BasicMath;

namespace BasicMathsTests
{
    public class BasicMathsTests
    {
        [Test]
        public void AddMethod()
        {
            BasicMath.BasicMath.Add(4, 6);
        }
        [Test]
        public void SubstractMethod()
        {
            BasicMath.BasicMath.Substrat(9, 3);
        }
        [Test]
        public void MultiplyMethod()
        {
            BasicMath.BasicMath.Multiply(10, 5);
        }
        [Test]
        public void DivideMethod()
        {
            BasicMath.BasicMath.Divide(12, 2);
        }
    }
}