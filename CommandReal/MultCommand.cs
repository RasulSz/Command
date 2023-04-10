using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandReal
{
    public class MultCommand : Calculate
    {
        Operation operation = new();
        public MultCommand() { }
        public MultCommand(Operation operation)
        {
            this.operation = operation;
        }
        public void Calculate(int a, int b)
        {
            operation.Mult(a, b);
        }
    }
}
