using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab7
{
    class Program
    {
        static void Main(string[] args)
        {
            string student = null;
            string hometown = null;
            string favoriteFood = null;
            string age = null;

            Console.WriteLine("Welcome to our classroom!");

            bool rep = true;
            while (rep)
            {
                Console.WriteLine("Listed below are the pupils in this class!\n");
                Console.WriteLine("1.) Sharkeisha ");
                Console.WriteLine("2.) Madison ");
                Console.WriteLine("3.) Jake ");
                Console.WriteLine("4.) Melissa ");
                Console.WriteLine("5.) Matthew ");
                Console.WriteLine("6.) Jan");
                Console.WriteLine("7.) David ");
                Console.WriteLine("8.) Michael ");
                Console.WriteLine("9.) Charlie ");
                Console.WriteLine("10.) Katrina");
                Console.WriteLine("11.) Logan ");

                Console.Write("Please enter a number for which student you would love to know more about: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        student = "Sharkeisha";
                        hometown = "Hell, Michigan";
                        favoriteFood = "Knuckle Sandwiches";
                        age = "23";
                        break;
                    case "2":
                        student = "Madison";
                        hometown = "Big Arm, Montana";
                        favoriteFood = "Pancakes";
                        age = "21";
                        break;
                    case "3":
                        student = "Jake";
                        hometown = "Chicken, Alaska";
                        favoriteFood = "Salad";
                        age = "22";
                        break;
                    case "4":
                        student = "Melissa";
                        hometown = "Coupon, Pennsylvania";
                        favoriteFood = "Pizza";
                        age = "21";
                        break;
                    case "5":
                        student = "Matthew";
                        hometown = "Dogtown, Alabama";
                        favoriteFood = "Chocolate Cake";
                        age = "21";
                        break;
                    case "6":
                        student = "Jan";
                        hometown = "Embarrass, Minnesota";
                        favoriteFood = "Popcorn";
                        age = "25";
                        break;
                    case "7":
                        student = "David";
                        hometown = "Experiment, Georgia";
                        favoriteFood = "Fried Cookie Dough";
                        age = "23";
                        break;
                    case "8":
                        student = "Michael";
                        hometown = "Fertile, Iowa";
                        favoriteFood = "Corn Dog";
                        age = "22";
                        break;
                    case "9":
                        student = "Charlie";
                        hometown = "Hazard, Nebraska";
                        favoriteFood = "Mac n' Cheese";
                        age = "22";
                        break;
                    case "10":
                        student = "Katrina";
                        hometown = "Hippo, Kentucky";
                        favoriteFood = "Apples";
                        age = "19";
                        break;
                    case "11":
                        student = "Logan";
                        hometown = "Kickapoo, Kansas";
                        favoriteFood = "Hashbrowns";
                        age = "11";
                        break;
                    default: //like a catch-all else--none of the cases were true
                        Console.WriteLine("\n\nSorry, that student doesn't exist! Make sure to pick a number from the ones listed below!");
                        rep = true;
                        continue;
                }
                Console.WriteLine();
                Console.WriteLine($"Student {input} is {student}! ");
                bool success = true;
                while (success)
                {
                    Console.WriteLine("Below is a few facts you can find out about them! ");
                    Console.WriteLine("1.) Hometown");
                    Console.WriteLine("2.) Favorite Food");
                    Console.WriteLine("3.) Age");
                    Console.Write($"Please pick a number for what fact you would like to learn about {student}: ");
                    string input2 = Console.ReadLine();

                    bool success2 = true;

                    while (success2)
                    {
                        if (input2 == "1")
                        {
                            Console.WriteLine($"\n{student} is from {hometown}!\n ");
                            break;
                        }

                        else if (input2 == "2")
                        {
                            Console.WriteLine($"\n{student}'s favorite food is {favoriteFood}!\n ");
                            break;
                        }

                        else if (input2 == "3")
                        {
                            Console.WriteLine($"\n{student}'s age is {age}!\n ");
                            break;
                        }

                    }

                    Console.Write("Would you like to know more about this student? (y/n) : ");
                    string answer = Console.ReadLine().ToLower();
                    Console.WriteLine();
                    if (answer == "y")
                    {
                        success = true;
                    }

                    else if (answer == "n")
                    {
                        Console.Write("Would you like to learn about another student? (y/n): ");
                        string answer2 = Console.ReadLine().ToLower();
                        if (answer2 == "y")
                        {
                            success = false;
                            rep = true;
                        }

                        else if (answer2 == "n")
                        {
                            Console.WriteLine("Thank you for learning about our classroom!");
                            return;
                        }
                    }
                }
            }
        }
    }
}