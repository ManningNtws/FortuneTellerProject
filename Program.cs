using System;

namespace FortuneTellerProject
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // askingquestions
            Console.WriteLine("first name:");
            string fname = Console.ReadLine();

            Console.WriteLine("last name:");
            string lname = Console.ReadLine();
             

            Console.WriteLine("age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("# of siblings:");
            int numofsib = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("# of pets:");
            int numofpets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("# of month:");
            int numofmonth = Convert.ToInt32(Console.ReadLine());

            string ROYGBIV;
            while (true)
            {
                Console.WriteLine("fav ROYGBIV or type help for help:");
                ROYGBIV = Console.ReadLine();
                ROYGBIV = ROYGBIV.ToLower();
                if (ROYGBIV != "red" || ROYGBIV != "orange" || ROYGBIV != "Yellow" || ROYGBIV != "Green" || ROYGBIV != "blue" || ROYGBIV != "indigo" || ROYGBIV != "violet")
                {
                    if (ROYGBIV == "help")
                    {
                        Console.WriteLine("ROYGBIV = Red, Ornge, Yellow, Green, Blue, Indigo, and Violet");
                    }
                    else
                    {
                        Console.WriteLine("enter a valid input");
                    }

                }

                else
                {
                    break;
                }
            }


            //College
            string College;
            if (numofsib == 0)
            {
                College = "Princeton University";
            }
            else if (numofsib == 1)
            {
                College = "Columbia University";
            }
            else if (numofsib == 2)
            {
                College = "Harvard University";
            }
            else if (numofsib == 3)
            {
                College = "Massachusetts Institute of Technology";
            }
            else if (numofsib > 3)
            {
                College = "Yale University";
            }
            else
            {
                College = "Stanford University";
            }


            //Transportation
            string Transportation;
            if (ROYGBIV == "Lowercase: red")
            {
                Transportation = "walking";
            }
            else if (ROYGBIV == "Lowercase: orange")
            {
                Transportation = "bike";
            }
            else if (ROYGBIV == "Lowercase: yellow")
            {
                Transportation = "car";
            }
            else if (ROYGBIV == "Lowercase: green")
            {
                Transportation = "train";
            }
            else if (ROYGBIV == "Lowercase: blue")
            {
                Transportation = "bus";
            }
            else if (ROYGBIV == "Lowercase: Indigo")
            {
                Transportation = "boat";
            }
            else
            {
                Transportation = "plane";
            }

            //Salary
            string Salary;
            if (numofmonth <= 1 || numofmonth <= 4)
            {
                Salary = "$1,000.00";
            }
            else if (numofmonth <= 5 || numofmonth <= 8)
            {
                Salary = "$5,000.00";
            }
            else if (numofmonth <= 9 || numofmonth <= 12)
            {
                Salary = "$10,000.00";
            }
            else
            {
                Salary = "$0.00";
            }

            //Vacation Home Location
            string VHL;
            if (numofsib % 2 == 0)
            {
                VHL = "Florida";
            }
            else
            {
                VHL = "California";
            }
            //kids
            string kids;
            if (age <= 1 || age <= 16)
            {
                kids = "3";
            }
            else if (age <= 17 || age <= 20)
            {
                kids = "3";
            }
            else
            {
                kids = "1";
            }

            Console.WriteLine($"{fname} {lname}, you will go to {College}, travel by {Transportation} make {Salary}, have a vacation home in {VHL}, and have {kids} kids.");



        }





    }
}
