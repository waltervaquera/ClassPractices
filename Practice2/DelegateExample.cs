using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class DelegateExample
    {
        delegate int MathOperation(int a, int b);

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static void Main(string[] args)
        {
            MathOperation operation = Add;
            Console.WriteLine("Add: 5 + 3 = " + operation(5, 3));

            operation = Subtract;
            Console.WriteLine("Subtract: 5 - 3 = " + operation(5, 3));

            MathOperation multicastOperation = Add;
            multicastOperation += Subtract;
            Console.WriteLine("Multicast: 5, 3 = " + operation(5, 3));

        }
    }
}
