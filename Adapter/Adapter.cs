using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter
{
    public class Adapter : ITarget
    {
        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }
        private Adaptee adaptee;
        public void Output5V()
        {
            adaptee.Output220V();
            Console.WriteLine("adapting ...");
            Console.WriteLine("Output5V");
        }
    }
}
