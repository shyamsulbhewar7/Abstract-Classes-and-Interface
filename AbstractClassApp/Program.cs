using System;

namespace AbstractClassApp
{
    public abstract class Example
    {
        public abstract void Solve();
    }
    public class E1 : Example
    {
        public override void Solve()
        {
            Console.WriteLine("This example 1");
        }
    }
    public class E2 : Example
    {
        public override void Solve()
        {
            Console.WriteLine("This example 2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Example eg;
            eg = new E1();
            eg.Solve();
            eg = new E2();
            eg.Solve();
            /*
                Generally, we use abstract class at the time of inheritance.
                A user must use the override keyword before the method is declared as 
                abstract in the child class, the abstract class is used to inherit in the child class.
                An abstract class cannot be inherited by structures.
                It can contain constructors or destructors.
                It can implement functions with non-Abstract methods.
                It cannot support multiple inheritances.
                It can’t be static.
            */
        }
    }
}
