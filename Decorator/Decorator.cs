using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class Decorator:Component
    {
        public Decorator(Component component)
        {
            this.component = component;
        }
        private Component component;
        public override void Operation()
        {
            System.Console.WriteLine("Decorator");
            component.Operation();
        }
    }
}
