
namespace DesignPatterns.FactoryMethod
{
    /// <summary>
    /// 工厂方法适合不同的用户和产品有绑定关系的场合
    /// 这样我们可以把产品的变化放到子类中
    /// 变化部分：产品的变化
    /// 不变部分： 对产品的需要
    /// </summary>
    internal class Test
    {
        public static void Run()
        {
            IUser user = new UserA();
            IProduct product = user.GetProduct();
            product.Run();
        }
    }
}
