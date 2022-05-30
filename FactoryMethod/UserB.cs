using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod
{
    public class UserB : IUser
    {
        public IProduct GetProduct()
        {
            ProductB product = new ProductB();
            return product;
        }
    }
}
