using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program01
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Insert the length: ");//Prompt

        int length = 0;
        bool invalid;
        do
        {
            invalid = false;//Resetting flag in orded to possibly leave loop
            string input = Console.ReadLine();//Reading input
            if (input == null) input = "";//Resolving null exception for compiler sake

            try
            {
                length = int.Parse(input);//Converting input to number
            } catch (Exception ex)
            {
                invalid = true;//Uh oh, no number can be read
            }


        } while (invalid);

        string buffer = "*";//Just a string buffer to avoid clogging the output stream for every single character

        Console.WriteLine("\n");

        for (int i=0; i < length; i++)
        {
            Console.WriteLine(buffer);//Output of this iteration
            buffer += '*';//Put one more character to the buffer for the next iteration
        }
    }
}
