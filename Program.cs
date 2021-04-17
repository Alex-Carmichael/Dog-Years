using System;

namespace Dog_Years
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {

                    Console.Write("How  old is your dog? ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    int humanAge;

                    
                    if (age >= 3)
                    {
                        age = age - 2;
                        age = age * 7;
                        humanAge = 25 + age;
                        Console.WriteLine("Your dog is " + humanAge + " years old in human years");
                        break;

                    }
                    else if (age >= 2)
                    {
                        humanAge = 25;
                        Console.WriteLine("Your dog is " + humanAge + " years old in human years");
                        break;
                    }
                    else if (age >= 1)
                    {
                        humanAge = 15;
                        Console.WriteLine("Your dog is " + humanAge + " years old in human years");
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("That is not a valid input");
                    Console.WriteLine("Try Again");
                }
            }
        }
    }
}
