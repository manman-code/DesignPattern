using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod
{
    public class UserA : IUser
    {
        public IProduct GetProduct()
        {
            ProductA product = new ProductA();
            return product;
        }
    }
}
