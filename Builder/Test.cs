using System;

namespace DesignPatterns.Builder
{
    //适用于复杂对象的创建，建造过程和建造细节的分离
    //便于控制细节风险
    //变化：建造细节变化，建造组件种类是不变化的
    public class Test
    {
        public static void Run()
        {
            Product.Builder builder = new Product.Builder();
            Director director = new Director(builder);
            Product product = director.MakeProduct();
            Console.WriteLine(product.ToString());
        }
    }
}
