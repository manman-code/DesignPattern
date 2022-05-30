using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    /// <summary>
    /// 拓展一个类的功能，给一个类附加职责
    /// </summary>
    public static class Test
    {
        public static void Run()
        {
            Component component = new ConcreteComponent();
            Decorator decorator = new Decorator(component);
            decorator.Operation();
        }
    }
}
