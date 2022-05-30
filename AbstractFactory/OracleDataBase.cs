
namespace DesignPatterns.AbstractFactory
{
    public class OracleDataBase : DataBase
    {
        public override ICommand GetCommand()
        {
            return new OracleCommand();
        }

        public override IConnection GetConnection()
        {
            return new OracleConnection();
        }
    }
}
