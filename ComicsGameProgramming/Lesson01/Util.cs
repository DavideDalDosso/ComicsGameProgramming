using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Util
{
    public static int ReadInt(Action wrongFormatAction)
    {
        int number = 0;
        bool invalid;
        do
        {
            invalid = false;
            string input = Console.ReadLine();//Reading input
            if (input == null) input = "";//Resolving null exception for compiler sake

            try
            {
                number = int.Parse(input);//Converting input to number
            }
            catch (Exception ex)
            {
                invalid = true;//Uh oh, no number can be read
                wrongFormatAction.Invoke();
            }


        } while (invalid);

        return number;
    }
}
