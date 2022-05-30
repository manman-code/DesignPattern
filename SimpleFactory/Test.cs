
namespace DesignPatterns.SimpleFactory
{
    internal class Test
    {
        public static void Run()
        {
            IProduct product = SimpleFactory.CreateProduct(1);
            product.Run();
        }
    }
}
