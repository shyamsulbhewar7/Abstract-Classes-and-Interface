using InterfaceApp.Model;
using System;

namespace InterfaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Human person1 = new Human();
            Console.WriteLine("Interface example");
            person1.Adult();
            person1.Kid();
            /*
            Interfaces specify what a class must do and not how.
            Interfaces can’t have private members.
            By default all the members of Interface are public and abstract.
            The interface will always defined with the help of keyword ‘interface‘.
            Interface cannot contain fields because they represent a particular implementation of data.
            Multiple inheritance is possible with the help of Interfaces but not with classes.
            */
        }
    }
}
