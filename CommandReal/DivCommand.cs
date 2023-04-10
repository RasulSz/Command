using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandReal
{
    public class DivCommand : Calculate
    {
        Operation operation = new();
        public DivCommand() { }
        public DivCommand(Operation operation)
        {
            this.operation = operation;
        }
        public void Calculate(int a, int b)
        {
            operation.Div(a, b);
        }
    }
}
