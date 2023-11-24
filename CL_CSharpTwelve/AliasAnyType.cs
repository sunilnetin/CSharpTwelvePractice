using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point = (int x, int y);
using Cat = System.Text.StringBuilder;
using Age = System.Int32;

namespace CL_CSharpTwelve
{
    public class AliasAnyType
    {

        Point Copy(Point source)
        {
            return new Point(source.x, source.y);
        }
        public void PrintAliasAnyType() 
        {
          var point=  Copy(new Point(10, 20));
            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
        }

        public void PrintAliasAnyType2()
        {
            Cat cat = new Cat();
            cat.Append("sparky");
            cat.Append(100);

            Console.WriteLine(cat);
        }

        public void PrintAliasAnyType3(Age age)
        {
            Console.WriteLine(age.GetType());
            Console.WriteLine($"Yours age is : {age}");
        }
    }
}
