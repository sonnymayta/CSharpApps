namespace ConsoleUnit.Tests
{
    public class AplicationTests
    {
        [Fact]
        public void Add_TwoPositiveIntegers_ReturnsCorrectSum()
        {
            // Arrange
            Aplication aplication = new();            
            // Act
            var result = aplication.Add(5, 10);
            // Assert
            Assert.Equal(15, result);
        }

        [Theory]
        [InlineData(5, 4, 1)]
        [InlineData(10, 3, 7)]
        public void SubtractTest(int a, int b, int expected)
        {
            // Arrange
            Aplication aplication = new();
            // Act
            var result = aplication.Subtract(a, b);
            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void MultiplyTest()
        {
            Aplication aplication = new();
            var result = aplication.Multiply(5, 5);
            Assert.Equal(25, result);
        }

        [Fact]
        public void IsZeroTest()
        {
            Aplication aplication = new();
            var result = aplication.IsZero(0);
            Assert.True(result);
        }

        [Fact]
        public void DivideTest()
        {
            Aplication aplication = new();
            var result = aplication.Divide(10, 2);
            Assert.Equal(5, result);
        }

        [Fact]
        public void DivideByZeroTest()
        {
            Aplication aplication = new();
            var result = aplication.Divide(10, 0);
            Assert.Null(result);
        }
    }
}
