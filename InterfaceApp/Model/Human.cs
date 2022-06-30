using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceApp.Model
{
    public interface Man
    {
        void Kid();
        void Adult();
    }
    public class Human : Man
    {
        public void Kid()
        {
            Console.WriteLine("I am kid");
        }
        public void Adult()
        {
            Console.WriteLine("I am adult");
        }
    }
}
