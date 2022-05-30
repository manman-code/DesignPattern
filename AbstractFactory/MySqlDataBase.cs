using System;

namespace DesignPatterns.AbstractFactory
{
    public class MySqlDataBase : DataBase
    {
        public override ICommand GetCommand()
        {
            return new MySqlCommand();
        }

        public override IConnection GetConnection()
        {
            return new MySqlConnection();
        }
    }
}
