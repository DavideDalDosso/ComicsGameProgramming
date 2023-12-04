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

        bool guessed;//Our flag for the DO WHILE loop
        do
        {
            string input = Util.ReadString();

            guessed = !passwordLock.CheckCorrect(input);//If it's wrong, mark for another attempt

            if(!guessed) Console.WriteLine("Unfortunately the password is wrong. Please retry... "); //Wrong answer message

        } while (!guessed);//Retry the procedure if it's wrong

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
