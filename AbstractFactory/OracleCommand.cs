using System;


namespace DesignPatterns.AbstractFactory
{
    public class OracleCommand : ICommand
    {
        public void Run()
        {
            Console.WriteLine("OracleCommand");
        }
    }
}
