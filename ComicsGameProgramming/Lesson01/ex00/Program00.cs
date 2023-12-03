using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program00
{
    public static void Main()
    {
        //Instancing our custom class alongside the password
        PasswordLock passwordLock = new PasswordLock("Our secret 1337");

        Console.WriteLine("Please insert the password: ");//Prompt

        Util.ReadInt(() =>//TODO make a string version
        {

        });

        bool invalid;//Our flag for the DO WHILE loop
        do
        {
            string input;//The buffer for input

            input = Console.ReadLine();//Reading input
            if (input == null) input = "";//Resolving null exception for compiler sake

            invalid = !passwordLock.CheckCorrect(input);//If it's wrong, mark for another attempt

            if(invalid) Console.WriteLine("Unfortunately the password is wrong. Please retry... "); //Wrong answer message

        } while (invalid);//Retry the procedure if it's wrong

        Console.WriteLine("Congratulations, the password is correct. ");
    }

    public class PasswordLock
    {
        private string password;
        public PasswordLock(string password)
        {
            this.password = password;
        }
        public bool CheckCorrect(string password)//Check if the password equals the parameter
        {
            return password.Equals(this.password);
        }
    }

}
