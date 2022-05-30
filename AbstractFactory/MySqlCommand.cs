using System;

namespace DesignPatterns.AbstractFactory
{
    public class MySqlCommand : ICommand
    {
        public void Run()
        {
            Console.WriteLine("MySqlCommand");
        }
    }
}
