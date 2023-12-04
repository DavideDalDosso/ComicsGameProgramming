using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program04
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please insert how many numbers to put: ");

        int nNumbers = Util.ReadInt(() =>
        {
            Console.WriteLine("Please insert a valid number");
        });

        int[] array = new int[nNumbers];

        Console.WriteLine("Please put as many numbers as requested before: ");

        for (int i = 0; i < nNumbers; i++)
        {
            array[i] = Util.ReadInt(() =>
            {
                Console.WriteLine("Please insert a valid number");
            });
        }

        Console.WriteLine("\n");

        Console.WriteLine(Util.ArrayToString(array));//TODO: IMPLEMENT SHIFT
    }

    public static int[] LeftShiftArray(int[] array, int offset)
    {
        return null;
    }

    public static int[] RightShiftArray(int[] array, int offset)
    {
        return null;
    }
}
