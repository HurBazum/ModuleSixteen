using System.Numerics;

namespace ModuleSixteen
{
    public class Calculator
    {
        public int Additional(int a, int b) => checked(a + b);

        public int Subtraction(int a, int b) => checked(a - b);

        public int Multiplication(int a, int b) => checked(a * b);

        public int Division(int a, int b) => checked(a / b);
    }
}