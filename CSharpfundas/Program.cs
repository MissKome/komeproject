// See https://aka.ms/new-console-template for more information

using OpenQA.Selenium.DevTools.V102.Database;
using System;

namespace CSharpfundas
{
    class Program : Program4
    {
        string name;

        public Program(string name)
        {
           this.name = name;
        }

        public void getName()
        {
            Console.WriteLine("My name is" + this.name);
        }
        public void getData()
        {
            Console.WriteLine("I am inside the method");
        }

        static void Main(string[] args)
        {
            Program p = new Program("Kome");

            p.getData();
            p.getName();    
            p.SetData();

            Console.WriteLine("Hello, World!");
            int a = 4;
            // Double c = 3.12;
            Console.WriteLine("number is" + a);

            string name = "kome";
            Console.WriteLine("name is" + name);

            Console.WriteLine($"name is {name}");

            var age = 23;
            Console.WriteLine("age is" + age);
          // age = "hello";

            dynamic height = 13.2;
            Console.WriteLine($"height is + { height}");

            height = "hello";
            Console.WriteLine($"height is {height}");
        }
    }
}




