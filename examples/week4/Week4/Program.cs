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

        Breakout b = new Breakout();

        b.Run2();
    }
}
