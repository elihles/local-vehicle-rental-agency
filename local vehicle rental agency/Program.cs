using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace local_vehicle_rental_agency
{
    internal class Program
    {
        const int AutorEconomy = 50;
        const int SUV = 80;
        const int Automatic = 150;
        const int suv = 300;
        const int Economy = 120;
        static void Main(string[] args)
        {
            char details;
            double totalIncome = 0;
            do
            {
               
                (string choice, int numberOfdays) = getDetails();
                int insuranceAmount = GetInsurance(choice, numberOfdays);
                double finalAmount = CalcAmount(choice, numberOfdays, insuranceAmount);
                totalIncome += finalAmount;
                Console.Write("Do you want to enter more details?");
                details = char.ToUpper(Console.ReadLine()[0]);
                if(details == 'N')
                {
                    break;
                }
                


            }
            while (details=='Y');
            Console.WriteLine("The estimated total income is {0:C}", totalIncome);
            Console.ReadLine();


        }
        static (string,int) getDetails() 
        {
            string choice;
            int numberOfdays;
            Console.Write("Enter the type of vehicle (automatic,economy,suv) :");
            choice = (Console.ReadLine()).ToLower();
            Console.Write("Enter the number of days :");
            numberOfdays=int.Parse(Console.ReadLine());
            
            return (choice,numberOfdays);
        }
        static int GetInsurance(string choice, int numberOfdays)
        {
            char include;
            int insurance;
            Console.Write("Would you like to include vehicle insurance (Y/N) :");
            include = char.ToUpper(Console.ReadLine()[0]);
            if (include == 'Y')
            {
                insurance = AutorEconomy * numberOfdays;
            }
            else
            {
                insurance = SUV * numberOfdays;
            }
            return insurance;
        }
        static double CalcAmount(string choice, int numberOfdays, int insuranceAmount)
        {
            double rentalAmount;
            if (choice == "automatic")
            {
                rentalAmount = Automatic * numberOfdays; ;
                
            }
            else if (choice == "economy")
            {
                rentalAmount = Economy * numberOfdays;

            }
            else
            {
                rentalAmount = suv * numberOfdays;

            }
            double finalAmount = rentalAmount + insuranceAmount;
            Console.WriteLine("The amount for this transaction is {0:C}", finalAmount);

            return finalAmount;

        }


    }
}
