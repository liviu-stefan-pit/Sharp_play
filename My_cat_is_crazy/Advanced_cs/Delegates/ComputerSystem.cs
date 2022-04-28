using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_cs.Delegates
{
    public class ComputerSystem
    {
        public string StartApp(string name)
        {
            return $"start app {name}";
        }

        public string StopApp(string name)
        {
            return $"stop app {name}";
        }

        public void Operation(string name, OperationDelegate operationDelegate)
        {
            Console.WriteLine($"Result: {operationDelegate(name)}");
        }

        public void MulticastTest1(string name)
        {
            Console.WriteLine($"test 1: {name}");
        }

        public void MulticastTest2(string name)
        {
            Console.WriteLine($"test 2: {name}");
        }
    }
}
