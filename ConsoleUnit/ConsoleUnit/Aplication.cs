namespace ConsoleUnit
{
    public class Aplication
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public double? Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
                return null;
            }
        }
        public bool IsZero(int a)
        {
            if (a == 0) return true;
            return false;
        }
    }
}
