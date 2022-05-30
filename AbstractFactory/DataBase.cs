
namespace DesignPatterns.AbstractFactory
{
    public abstract class DataBase
    {
        public abstract IConnection GetConnection();

        public abstract ICommand GetCommand();
       
    }
}
