using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public class OracleConnection : IConnection
    {
        public void Connect()
        {
            Console.WriteLine("OracleConnection");
        }
    }
}
