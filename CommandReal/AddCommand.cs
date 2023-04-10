using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandReal
{
    public class AddCommand : Calculate
    {
        Operation operation = new();
        public AddCommand() { }
        public AddCommand(Operation operation)
        {
            this.operation = operation;
        }
        public void Calculate(int a, int b)
        {
            operation.Add(a, b);
        }
    }
}
