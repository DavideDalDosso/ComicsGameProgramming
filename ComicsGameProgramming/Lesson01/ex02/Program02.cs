using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program02
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Insert the length: ");//Prompt

        int length = 0;
        int height = 0;
        bool invalid;
        do
        {
            invalid = false;
            string input = Console.ReadLine();//Reading input
            if (input == null) input = "";//Resolving null exception for compiler sake

            try
            {
                length = int.Parse(input);//Converting input to number
            }
            catch (Exception ex)
            {
                invalid = true;//Uh oh, no number can be read
            }


        } while (invalid);

        Console.WriteLine("Insert the height: ");//Prompt

        do//Same deal but for a different variable
        {

            invalid = false;
            string input = Console.ReadLine();
            if (input == null) input = "";

            try
            {
                height = int.Parse(input);
            }
            catch (Exception ex)
            {
                invalid = true;
            }


        } while (invalid);//We can recycle the previous flag for this loop too

        string buffer = "";//Just a string buffer to avoid clogging the output stream for every single character
        string buffer2 = "";

        Console.WriteLine("\n");

        for (int i = 0; i < length; i++)
        {
            buffer += "*";
        }

        buffer += "\n";

        for (int i = 0; i < height; i++)
        {
            buffer2 += buffer;
        }

        Console.WriteLine(buffer2);//Output of this iteration
    }


}
