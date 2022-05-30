using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SimpleFactory
{
    public class ProductA : IProduct
    {
        public void Run()
        {
            Console.WriteLine("ProductA");
        }
    }
}
