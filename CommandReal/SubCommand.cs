using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandReal
{
    public class SubCommand : Calculate
    {
        Operation operation = new();
        public SubCommand() { }
        public SubCommand(Operation operation)
        {
            this.operation = operation;
        }
        public void Calculate(int a, int b)
        {
            operation.Sub(a, b);
        }
    }
}
