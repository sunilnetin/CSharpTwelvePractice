using CL_CSharpTwelve;
// See https://aka.ms/new-console-template for more information
#region Top Level Statement
Console.WriteLine("Hello, World! ->Sunil");
//Console.WriteLine(args);
//Console.WriteLine(args.Length);
//Console.WriteLine("args : " + args?[0]);

//var parson = new Parson { Name = "Sunil Kumar Gupta" };
//Console.WriteLine(parson?.Name);
#endregion Top Level Statement
#region Task Async&Await
//return await Task.FromResult(1);
//return args.Length;

//Practice#1
// var r  =MyAsc.Method1();
// Console.WriteLine(r);
//Practice#2
Task task1 = Task.Run(() =>
{
    var r1 = MyAsc.Method1();
    Console.WriteLine(r1);
});

Task task2 = Task.Run(() =>
{
    var r2 = MyAsc.Method2();
    Console.WriteLine(r2);
});

Task task3 = Task.Run(() =>
{
    var r3 = MyAsc.Method3();
    Console.WriteLine(r3);
});

MyAsc.Method1_2();
Console.ReadKey();

#endregion Task Async&Await
#region The *spread operator*, `..`


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
// 1, 2, 3, 4, 5, 6, 7, 8, 9,

SpreadOperator so = new SpreadOperator();
so.Example1();
so.Example2();
Console.WriteLine("----------------Collection Expration------------------");
so.CollectionExpration();

#endregion The *spread operator*, `..`
#region #Primary Constructor 
//#Primary Constructor 
Console.WriteLine("-------Learning Primary Constructor---------");
PrimaryConstructor pc = new PrimaryConstructor("Sunil-> Primary Constructor!");
Console.WriteLine(pc.Name);

User u = new User("Sunil -> Primary Constructor using Records!");
Console.WriteLine(u);

var point1 = new GeoPointRecord(50, 230);
var point2 = point1 with { latitude = 100 };

var point3 = new GeoPointClass(50, 230);
// This line won't compile because no Latitude property exists. because its a class not a records.
//--var point4 = point3 with { latitude = 100 };


#endregion #Primary Constructor 

#region InlineArray

InlineArrays ia = new InlineArrays();
Console.WriteLine("-----------Print Inline Arrays---------");
ia.PrintInlineArrays();

#endregion InlineArray



#region  Async&Await
public class Parson
{
    public string? Name { get; set; }
}

public static class MyAsc
{
    public static int Method1()
    {
        Thread.Sleep(900);
        return 10;
    }

    public static int Method2()
    {
        return 20;
    }

    public static int Method2(int i)
    {
        return 20 * i;
    }

    public static int Method3()
    {
        return 30;
    }

    public static async void Method1_2()
    {
        System.Console.WriteLine("Async & Await Test--");
        var i = await Task.Run(() =>
        {
            return Method1();
        });

        System.Console.WriteLine(i);
        int j = Method2(i);
        System.Console.WriteLine(j);
    }
    #endregion Async&Await
}