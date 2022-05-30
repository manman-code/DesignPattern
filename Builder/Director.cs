using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class Director
    {
        Product.Builder builder;
        public Director(Product.Builder builder)
        {
            this.builder = builder;
        }
        //这里控制建造过程
        public Product MakeProduct()
        {
            builder.ProductName("car");
            builder.CompanyName("Tesla");
            builder.Part1("p1");
            builder.Part1("p2");
            builder.Part1("p3");
            builder.Part1("p4");
            Product product = builder.Build();
            return product;
        }
    }
}
