using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    /// <summary>
    /// 变化：数据库的类型，因为数据库类型，不变的：连接和命令操作
    /// 数据库类型和操作是一对多关系
    /// 所有用一个抽象的工厂类来产生操作
    /// </summary>
    public class Test
    {
        public static void Run()
        {
            DataBase db = new MySqlDataBase();
            IConnection connect = db.GetConnection();
            connect.Connect();
            ICommand command = db.GetCommand();
            command.Run();
        }
    }
}
