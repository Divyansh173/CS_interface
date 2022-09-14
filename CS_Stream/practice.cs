using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Stream
{
    public class practice
    {
        public int add(int a, int b) {
            return a + b;
        }

        public virtual void sub(int a, int b) {
            Console.WriteLine(a-b);
        }
    }

    public class practice1 : practice 
    {
        public new void add(int a, float b, int c) {
            Console.WriteLine(a + b + c);
        }

        public override void sub(int a, int b) {
            Console.WriteLine(a+b);
        }
    }
}
