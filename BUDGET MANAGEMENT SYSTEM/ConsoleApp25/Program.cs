// See https://aka.ms/new-console-template for more information

using System.Data.SqlTypes;
using System.Diagnostics;
using System.Xml.Serialization;

Console.WriteLine("--------------------------");
Console.WriteLine(" BUDGET MANAGEMENT SYSTEM");
Console.WriteLine("--------------------------");
Console.WriteLine("\n");

string existingusername = "JulyaMazing";
int existingpassword = 199930;
string username = "";
int password = 0;

do
{
    Console.WriteLine("-----------------------");
    Console.Write(" Username: ");
    username = Console.ReadLine();

    Console.Write(" Password: ");
    password = int.Parse(Console.ReadLine());
    Console.WriteLine("-----------------------");

    if (username != existingusername && password != existingpassword)
    {
        Console.WriteLine("Invalid Credentials. Re-try.");
    }
    else if (username != existingusername)
    {
        Console.WriteLine("Invalid Username! Re-try.");
    }
    else if (password != existingpassword)
    {
        Console.WriteLine("Invalid Password! Re-try.");
    }
} while (username != existingusername || password != existingpassword);

Console.WriteLine("LOG-IN SUCCESSFUL");
Console.WriteLine("\n");
Console.WriteLine("------------------------------------");
Console.WriteLine(" Welcome to BUDGET TRACKER DASHBOARD");
Console.WriteLine("------------------------------------");
Console.WriteLine("\n");

string TrackExp = "1";
string TrackGoal = "2";
string Exit = "3";
string activity = "";

do
{
    Console.WriteLine("-----------------------");
    Console.WriteLine("1. Track Expenses");
    Console.WriteLine("2. Track Savings Goal");
    Console.WriteLine("3. Exit");

    Console.Write("Choose an activity: ");
    activity = Console.ReadLine();
    Console.WriteLine("-----------------------");
    Console.WriteLine("\n");
    

    if (activity == TrackExp)
    {
        Console.WriteLine("------------------");
        Console.WriteLine(" Expense Tracker");
        Console.WriteLine("------------------");

        Console.WriteLine("----------------------------------");
        Console.Write("Enter your starting budget: ");
        double start_budget = double.Parse(Console.ReadLine());
        double remain_budget = start_budget;
        Console.WriteLine("Remaining budget: " + remain_budget);
        Console.WriteLine("----------------------------------");
        Console.WriteLine("\n");

        double expAmount = 0;
        string choice = "YES";
        do
        {
            Console.WriteLine("----------------------------");
            Console.Write("Enter expense amount: ");
            expAmount = double.Parse(Console.ReadLine());
            remain_budget = remain_budget - expAmount;
            Console.WriteLine("Remaining budget: " + remain_budget);
            Console.WriteLine("----------------------------");

            if (remain_budget < 0)
            {
                Console.WriteLine("WARNING! Expense has exceeded budget!");
            }

            Console.WriteLine("\n");
            Console.Write("Enter more?(YES/NO): ");
            choice = Console.ReadLine().ToUpper();
            Console.WriteLine("\n");

        } while (choice == "YES");

            Console.WriteLine("Remaining budget: " + remain_budget);
            Console.WriteLine("\n");
    }
    else if (activity == TrackGoal)
    {
        Console.WriteLine("------------------");
        Console.WriteLine(" Savings Tracker");
        Console.WriteLine("------------------");

        Console.Write("Enter savings goal amount: ");
        double goalAmount = double.Parse(Console.ReadLine());
        double total_savings = 0;
        double goalLeft = 0;
        double savings = 0; 
        string choice1 = "YES";
        
        do
        {
            
            Console.Write("How much did you save today?: ");
            savings = double.Parse(Console.ReadLine());
            total_savings = total_savings + savings;
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Total Savings: " + total_savings);
            goalLeft = goalAmount - total_savings;
            Console.WriteLine("Money needed to reach goal: " + goalLeft);
            Console.WriteLine("-----------------------------------");

            if (total_savings >= goalLeft)
            {
                Console.WriteLine("CONGRATULATIONS! You have reached your goal!");
            }

            Console.WriteLine("\n");
            Console.Write("Add more?(YES/NO): ");
            choice1 = Console.ReadLine().ToUpper();
            Console.WriteLine("\n");

        } while (choice1 == "YES");

    }

} while (activity != Exit);

Console.WriteLine("Your feedback will be much appreciated.");


