using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_CSharpTwelve
{
    //Lambda expressions with default parameters or params arrays as parameters don't have natural types that correspond to Func<> or Action<> types. However, you can define delegate types that include default parameter values:
    delegate int IncrementByDelegate(int source, int increment = 1);
    delegate int SumDelegate(params int[] values);
    public class DefaultLambdaParameters
    {
        public void PrintDefultLambda()
        {
            var addWithDefault = (int addTo = 2) => addTo + 1;
            //addWithDefault(); // 3
            //addWithDefault(5); // 6
            Console.WriteLine(addWithDefault());
            Console.WriteLine(addWithDefault(5));
           var l= addWithDefault.Method.GetParameters()[0].DefaultValue; // 2
            Console.WriteLine(l);
        }

        public void PrintLambda2() {

            //Expression lambdas can also be converted to the expression tree types, as the following example shows:
            System.Linq.Expressions.Expression<Func<int, int>> e = x => x * x;
            Console.WriteLine(e);
            // Output:
            // x => (x * x)

            //You can use lambda expressions in any code that requires instances of delegate types or expression trees, for example as an argument to the Task.Run(Action) method to pass the code that should be executed in the background. You can also use lambda expressions when you write LINQ in C#, as the following example shows:
            int[] numbers = { 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(x => x * x);
            Console.WriteLine(string.Join(" ", squaredNumbers));
            // Output:
            // 4 9 16 25

            //You enclose input parameters of a lambda expression in parentheses. Specify zero input parameters with empty parentheses:
            Action line = () => Console.WriteLine("Hello C# Action - example parameter less Lambda.");
            line();

            //If a lambda expression has only one input parameter, parentheses are optional:
            Func<double, double> cube = x => x * x * x;
            var c= cube(2);
            Console.WriteLine(c);

            //Two or more input parameters are separated by commas:
            Func<int, int, bool> testForEquality = (x, y) => x == y;
            var two=testForEquality(2, 2);
            var three =testForEquality(2, 3);
            Console.WriteLine(two);
            Console.WriteLine(three);

            //Sometimes the compiler can't infer the types of input parameters. You can specify the types explicitly as shown in the following example:
            Func<int, string, bool> isTooLong = (int x, string s) => s.Length > x;
            Console.WriteLine(isTooLong(5,"Sunil"));

            //You can use discards to specify two or more input parameters of a lambda expression that aren't used in the expression:
            //Lambda discard parameters may be useful when you use a lambda expression to provide an event handler.
            Func<int, int, int> constant = (_, _) => 42;
            var r = constant(0,0);
            var r1 = constant(5,5);
            Console.WriteLine(r);
            Console.WriteLine(r1);

            //Beginning with C# 12, you can provide default values for parameters on lambda expressions. The syntax and the restrictions on default parameter values are the same as for methods and local functions. The following example declares a lambda expression with a default parameter, then calls it once using the default and once with two explicit parameters:
            var IncrementBy = (int source, int increment = 1) => source + increment;
            Console.WriteLine(IncrementBy(5)); // 6
            Console.WriteLine(IncrementBy(5, 2)); // 7

            //***You can also declare lambda expressions with params arrays as parameters:
            var sum = (params int[] values) =>
            {
                int sum = 0;
                foreach (var value in values)
                    sum += value;

                return sum;
            };

            var empty = sum();
            Console.WriteLine(empty); // 0

            var sequence = new[] { 1, 2, 3, 4, 5 };
            var total = sum(sequence);
            Console.WriteLine(total); // 15

            //***

            //Lambda expressions with default parameters or params arrays as parameters don't have natural types that correspond to Func<> or Action<> types. However, you can define delegate types that include default parameter values:
            //delegate int IncrementByDelegate(int source, int increment = 1);
            //delegate int SumDelegate(params int[] values);
            IncrementByDelegate incr = new IncrementByDelegate(IncrementBy);
            Console.WriteLine(incr(5,3));

            SumDelegate sumDelegate = new SumDelegate(sum);
            var total1 = sumDelegate(sequence);
            Console.WriteLine(total1); // 15

        }
    }
}
