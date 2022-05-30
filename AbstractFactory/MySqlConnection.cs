using System;

namespace DesignPatterns.AbstractFactory
{
    public class MySqlConnection : IConnection
    {
        public void Connect()
        {
            Console.WriteLine("MySqlConnection");
        }
    }
}
