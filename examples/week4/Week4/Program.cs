internal class Program
{
    private static void Main(string[] args)
    {
        // //Reference Types
        // int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // //They are zero indexed
        // for(int i = 0; i < array.Length; i++)
        // {
        //     Console.WriteLine($"index: {i} value: {array[i]}");
        // }

        // List<int> list = new List<int>();

        // for(int i = 0; i < 1000; i++)
        // {
        //     list.Add(i);
        // }

        // foreach(int x in list)
        // {
        //     Console.WriteLine($"{x}: Value");
        // }

        // foreach(int x in array)
        // {

        // }

        // Breakout b = new Breakout();
        // b.Run();

        int x = 100;
        x = InClass.Foo(x);
        Console.WriteLine(x);

        Foo f = new Foo();
        f.X = 100;
        InClass.Bar(f);
        Console.WriteLine(f.X);

        Dice d6 = new Dice(6);
        Roll(d6);

        Dice d20 = new Dice(20);
        Roll(d20);

        int[] arry = new int[] { 1, 2, 3, 4 };

        for(int i = 0; i < 10; i++)
        {
            try
            {
                Console.WriteLine(arry[i]);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Index {i} Is Out of Bounds, exception {ex.Message}");
                throw;
            }
        }

    }



    private static void Roll(Dice d)
    {
        for(int i = 0; i < 100; i++)
        {
            Console.WriteLine(d.Roll());
        }
    }
}
