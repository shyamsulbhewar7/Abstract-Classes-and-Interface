using System;

namespace DiamondProblemApp
{
    interface BaseInterface
    {
        void Write()
        {
            Console.WriteLine("In Base Interface");
        }
    }
    interface IDerivedInterface1 : BaseInterface
    {
        void BaseInterface.Write()
        {
            Console.WriteLine("In Derived Interface1");
        }
    }
    interface IDerivedInterface2 : BaseInterface
    {
        void BaseInterface.Write()
        {
            Console.WriteLine("In Derived Interface2");
        }
    }
    public class InheritingClass : IDerivedInterface1, IDerivedInterface2
    {
        public void Write()
        {
            Console.WriteLine("In Inheriting Class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            InheritingClass c1 = new InheritingClass();
            c1.Write();
        }
    }
}
