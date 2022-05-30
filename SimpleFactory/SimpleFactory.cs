using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SimpleFactory
{
    public static class SimpleFactory
    {
        public static IProduct CreateProduct(int pType)
        {
            if(pType == 1)
            {
                return new ProductA();
            }
            else if(pType == 2)
            {
                return new ProductB();
            }
            return null;
        }
    }
}
