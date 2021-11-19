using System;
using System.IO.Pipes;

namespace TaxThingy {
    class Program {
        static void Main(string[] args) {
            //ask user for yearly pay
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Enter Your years wages: ");
            Console.ForegroundColor = ConsoleColor.Green;
            //store pay amount
            double pay = double.Parse(Console.ReadLine());
            //calculate gross pay
            double gross = (double)pay / 12;
            //calculate gross pay minus taxable income
            double minustax = (double)gross - 1047.5;
            //calculate gross minus taxable income minus income tax
            double intax = (double)minustax / 20 * 100;
            //declare national insurance variable
            double nation; 
            //if over 967 one amount is deducted otherwise the lesser amount is taken
            if (gross > 967) {
                nation = (double)(((gross - 967) * 2 / 100) + ((967 - 184) * 12 / 100));

                }
            else {
                nation = ((double)((gross - 184) / 12 * 100));
                }
            //add the national insurance amount to the income tax
            double natincome = (double) intax + nation;
            //work out total by taking the combined income tax and national insurance from the gross pay
            //then printing to console
            Console.WriteLine();
            double outcome = gross - natincome;
            Console.WriteLine("Wow you earn");
            Console.WriteLine("£" + outcome);
            Console.WriteLine("1st rounds on you");
            //keep console open
            Console.ReadKey();
            }
        }
    }

