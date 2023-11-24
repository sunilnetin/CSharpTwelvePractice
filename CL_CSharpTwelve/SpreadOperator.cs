namespace CL_CSharpTwelve
{
    public class SpreadOperator
    {
        // Create an array:
        int[] a = [1, 2, 3, 4, 5, 6, 7, 8];

        // Create a list:
        List<string> b = ["one", "two", "three"];

        // Create a span
        //Span<char> c = ['a', 'b', 'c', 'd', 'e', 'f', 'h', 'i'];

        // Create a jagged 2D array:
        int[][] twoD = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];

        // Create a jagged 2D array from variables:
        int[] row0 = [1, 2, 3];
        int[] row1 = [4, 5, 6];
        int[] row2 = [7, 8, 9];

        public void CollectionExpration()
        {
            Console.WriteLine("Create an array:");
            foreach (var _a in a)
                Console.WriteLine(_a);
            Console.WriteLine("Create a list:");
            foreach (var _b in b)
                Console.WriteLine(_b);
            Console.WriteLine("Create a span");
            //Create a span
            Span<char> c = ['a', 'b', 'c', 'd', 'e', 'f', 'h', 'i'];
            foreach (var _c in c)
                Console.WriteLine(_c);

            Console.WriteLine("Create a jagged 2D array:");
            foreach (var _twoD in twoD)
                foreach(var _t in _twoD)
                Console.WriteLine(_t);

            Console.WriteLine("Create a jagged 2D array from variables:");
            int[][] twoDFromVariables = [row0, row1, row2];
            foreach (var _twoDFromVariables in twoDFromVariables)
                foreach (var _t in _twoDFromVariables)
                    Console.WriteLine(_t);

        }
        public void Example1()
        {
            //The *spread operator*, `..`
            int[] row0 = [1, 2, 3];
            int[] row1 = [4, 5, 6];
            int[] row2 = [7, 8, 9];
            int[] single = [.. row0, .. row1, .. row2];
            foreach (var element in single)
            {
                Console.Write($"{element}, ");
            }
            // output:
            // 1, 2, 3, 4, 5, 6, 7, 8, 9,
        }

        public void Example2()
        {
            //The *spread operator*, `..`
            int[] row0 = [1, 2, 3];
            int[] row1 = [4, 5, 6];
            int[] row2 = [7, 8, 9];
            int[] row3 = [10, 11, 12];
            int[] single = [.. row0, .. row1, .. row2, .. row3];
            foreach (var element in single)
            {
                Console.Write($"{element}, ");
            }
            // output:
            // 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,  11, 12,
        }
    }
}
