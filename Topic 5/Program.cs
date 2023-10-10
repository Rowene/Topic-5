using System.Diagnostics;
using System.Reflection;
using System.Runtime;

namespace Topic_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select which program you would like to run.");
            Console.WriteLine("'Bank', 'Parking' and 'Hurricane'");
            string Program = Console.ReadLine();
            Console.WriteLine();
            if (Program == "Bank")
            {
                Bank();
            }
            else if (Program == "Parking")
            {
                 Parking();
            }
            else if (Program == "Hurricane")
            {
                Hurricane();
            }
        }
        public static void Bank()
        {
            Random generator = new Random();
            bool paymentsPayed = false;
            int bankNavigator = 0;
            double numWithdraw = 0;
            double numDeposit = 0;
            double payCar = generator.Next(110, 650);
            double payHouse = generator.Next(900, 6500);
            double payTaxes = generator.Next(450, 1240);
            double totalPayments = payCar + payHouse + payTaxes;
            double numBalance = generator.Next(100, 720000);
            Console.WriteLine("Welcome to Ellis Bank.");
            if (paymentsPayed == false)
            {
                Console.WriteLine("You have $" + totalPayments + " payments due this month.");
            }
            while (bankNavigator == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Enter '1' for deposits.");
                Console.WriteLine("Enter '2' for withdrawal.");
                Console.WriteLine("Enter '3' to check account balance.");
                Console.WriteLine("Enter '4' to pay bills.");
                Console.WriteLine("Enter '0' to exit Ellis Bank.");
                Console.WriteLine();
                bankNavigator = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();
                if (bankNavigator == 1)
                {
                    Console.WriteLine("How much money do you have to deposit?");
                    numDeposit = Convert.ToDouble(Console.ReadLine());
                    if (numDeposit <= 0)
                    {
                        Console.WriteLine("Invalid Ammount.");
                    }
                    else
                    {
                        Console.WriteLine("Successfully deposited $" + Math.Round(numDeposit, 2) + " to your account, new total: $" + Math.Round(numBalance + numDeposit, 2));
                        numBalance += numDeposit;
                    }
                    numDeposit = 0;
                    bankNavigator = 0;
                }
                else if (bankNavigator == 2)
                {
                    Console.WriteLine("How much money are you taking out from your account?");
                    numWithdraw = Convert.ToDouble(Console.ReadLine());
                    if (numWithdraw <= 0)
                    {
                        Console.WriteLine("Invalid Number.");
                    }
                    else if (numWithdraw > numBalance)
                    {
                        Console.WriteLine("Insufficient Funds.");
                    }
                    else
                    {
                        Console.WriteLine("Successfully withdrawed $" + Math.Round(numWithdraw, 2) + " from your account, new total: $" + Math.Round(numBalance - numWithdraw, 2));
                        numBalance -= numWithdraw;
                    }
                    numWithdraw = 0;
                    bankNavigator = 0;
                }
                else if (bankNavigator == 3)
                {
                    Console.WriteLine("Your account total: $" + Math.Round(numBalance, 2));
                    bankNavigator = 0;
                }
                else if (bankNavigator == 4)
                {
                    Console.WriteLine("House Bills: $" + payHouse);
                    Console.WriteLine();
                    Console.WriteLine("Car Payments: $" + payCar);
                    Console.WriteLine();
                    Console.WriteLine("Taxes: $" + payTaxes);
                    Console.WriteLine();
                    Console.Write("Pay Bills/Payments, 'Y' Yes, 'N' No:  ");
                    string pay = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    if (paymentsPayed == true)
                    {
                        Console.WriteLine("You have payed for this month.");
                    }
                    else if (totalPayments > numBalance)
                    {
                        Console.WriteLine("Insufficient Funds.");
                    }
                    else if (pay == "Y")
                    {
                        Console.WriteLine("Successfully payed off this months payments.");
                        numBalance -= totalPayments;
                        paymentsPayed = true;
                    }
                    else if (pay == "y")
                    {
                        Console.WriteLine("Successfully payed off this months payments.");
                        numBalance -= totalPayments;
                        paymentsPayed = true;
                    }
                    else if (pay == "N")
                    {

                    }
                    else if (pay == "n")
                    {

                    }
                    else
                    {
                        Console.WriteLine("Invalid response.");
                    }
                    bankNavigator = 0;
                }
                else if (bankNavigator >= 5)
                {
                    Console.WriteLine("Invalid Number.");
                    bankNavigator = 0;
                }
                else
                {
                    bankNavigator = 1;
                }
            }
        }

        public static void Parking()
        {
            bool payed = false;
            int numHours = 0;
            int numMinutes = 0;
            int numCost = 0;
            Console.WriteLine("Ellis Parking, $4 to get the first hour, each additional hour costs $2 until $20 for the day.");
            Console.WriteLine("Each additional minute rounds up to an extra hour.");
            Console.WriteLine("*YOU CAN'T PARK FOR MORE THEN 24 HOURS*");
            Console.WriteLine();
            while (payed == false)
            {
                Console.Write("How many hours have you parking for? : ");
                numHours = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("How many minutes have you parked for? : ");
                numMinutes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (numMinutes > 60)
                {
                    Console.WriteLine("Invalid.");
                }
                else if (numMinutes < 0)
                {
                    Console.WriteLine("Invalid.");
                }
                else if (numHours < 0)
                {
                    Console.WriteLine("Invalid.");
                }
                else if (numHours > 24)
                {
                    Console.WriteLine("You cannot park for over 24 hours.");
                    Console.WriteLine("You've recieved a $250 fine & 2 demerit points.");
                    payed = true;
                }
                else if (numHours == 24 & numMinutes > 0)
                {
                    Console.WriteLine("You cannot park for over 24 hours.");
                    Console.WriteLine("You've recieved a $250 fine & 2 demerit points.");
                    Console.WriteLine();
                    payed = true;
                }
                else
                {
                    Console.WriteLine("You've parked for " + numHours + " hours and " + numMinutes + " minutes.");
                    numCost = (numHours * 2) + 2;
                    if (numMinutes > 0)
                    {
                        numCost += 2;
                    }
                    if (numCost >= 20)
                    {
                        numCost = 20;
                    }
                    payed = true;
                }
            }
        }

        public static void Hurricane()
        {
            int hurricaneLevel;
            Console.WriteLine("Select a Hurricane Intensity Level, 1 - 5.");
            Console.WriteLine();
            hurricaneLevel = Convert.ToInt16(Console.ReadLine());
            switch (hurricaneLevel)
            {
                case <= 0:
                    Console.WriteLine("Invalid Hurricane Intensity Level.");
                    break;
                case > 5:
                    Console.WriteLine("Invalid Hurricane Intensity Level.");
                    break;
                case 1:
                    Console.WriteLine("74 - 95 mph, or 64 - 82 knots, or 119 - 153 km/h.");
                    break;
                case 2:
                    Console.WriteLine("96 - 110 mph, or 83 - 95 knots, or 154 - 177 km/h.");
                    break;
                case 3:
                    Console.WriteLine("111 - 130 mph, or 96 - 113 knots, or 178 - 209 km/h."); 
                    break;
                case 4:
                    Console.WriteLine("131 - 155 mph, or 114 - 135 knots, or 210 - 249 km/h.");
                    break;
                case 5:
                    Console.WriteLine("156+ mph, or 136+ knots, or 250+ km/h."); 
                    break;
            }
        }
    }
}