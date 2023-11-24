using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_CSharpTwelve
{
    [System.Runtime.CompilerServices.InlineArray(10)]
    public struct Buffer
    {
        private int _element0;
    }
    public class InlineArrays
    {
        public void PrintInlineArrays() 
        { 
            var buffer = new Buffer();
            for (int i = 0; i< 10; i++)
            {
                buffer[i] = i;
            }

            foreach (var i in buffer)
            {
                Console.WriteLine(i);
            }
        }
    }
}
