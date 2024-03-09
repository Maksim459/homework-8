using System.Runtime.InteropServices;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        Program program = new Program();
        Console.WriteLine(program.Method());

    }
    public int Method()
    {
        int[] array = { 100, 2, 39, 4, 5, 3, 456, 65, 765, 56, 76 };
        int i = array.Length;
        int a = 0;
        int b = 1;
        int item = 0;
        int a1 = array[a];

        while (i > 1)
        {
            int b1 = array[b];
            if (a1 > b1)
            {
                item = a1;
            }
            else
            {
                item = b1;
            }
            a1 = item;

            b++;

            i--;



        }
       
        return item;
    }
}