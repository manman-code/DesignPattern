using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SimpleFactory
{
    internal class ProductB : IProduct
    {
        public void Run()
        {
            Console.WriteLine("ProductB");
        }
    }
}
