using System;
using System.Linq;
using System.Collections.Generic;

namespace StudentGradesProject
{
 
    public class Program
    {
        
        static void displayNumbers(List<int> allgrades)
        {
            for (int i = 0; i < allgrades.Count; i++)
            {
                Console.WriteLine(i + ") " + allgrades[i]);
            }
        }
        
        static void generateGrades(List<int> anArray)
        {
            Random rand = new Random();
            for (int i = 0; i < 50; i++)
            {
                anArray.Add(rand.Next(0, 101));
            }
        }
        
     static void Main(string[] args)
        {
            Random rand = new Random();
            int choice = 0;
            var studentGrades = new List<int>();
            generateGrades(studentGrades);
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to the main menu of the Student Grades Analyzer!");
                Console.WriteLine("What would you like to do now?");
                Console.WriteLine("1. Display All Grades (type 'display grades' or 'display')");
                Console.WriteLine("2. Randomize Grades (type 'randomize grades' or 'random')");
                Console.WriteLine("3. List Highest, Lowest, and Average Grades respectively (type 'stats')");
                Console.WriteLine("4. Count Honours (type 'Count Honours' or 'count')");
                Console.WriteLine("5. Exit (type exit or 'e')");
                Console.WriteLine("Enter Option Here: ");
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "display grades" | userInput.ToLower() == "display" | userInput == "1")
                {
                    choice = 1;
                }
                else if (userInput.ToLower() == "randomize grades" | userInput.ToLower() == "random" | userInput == "2")
                {
                    choice = 2;
                }
                else if (userInput.ToLower() == "stats" | userInput == "3")
                {
                    choice = 3;
                }
                else if (userInput.ToLower() == "count honours" | userInput.ToLower() == "count" | userInput == "4")
                {
                    choice = 4;
                }
                else if (userInput.ToLower() == "exit" | userInput.ToLower() == "e" | userInput == "5")
                {
                    choice = 5;
                }
                else
                {
                    choice = 0;
                }

                switch (choice)
                {
                    case 1: // Display all Numbers
                        Console.Clear();
                        Console.WriteLine("Here is a list of all the student grades that have been generated at their array element:");
                        displayNumbers(studentGrades);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 2: // Relist Numbers
                        Console.Clear();
                        displayNumbers(studentGrades);
                        Console.WriteLine("Now randomizing. Press any key to continue...");
                        Console.ReadKey();
                        studentGrades.Clear();
                        generateGrades(studentGrades);
                        Console.WriteLine("Grades randomized! Listing new grades: ");
                        displayNumbers(studentGrades);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 3: // List the Highest, Lowst, and Average Grades
                        displayNumbers(studentGrades);
                        Console.WriteLine("The highest grade from this list is " + studentGrades.Max() + ".");
                        Console.WriteLine("The lowest grade from this list is " + studentGrades.Min() + ".");
                        Console.WriteLine("The highest grade from this list is " + studentGrades.Average() + ".");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 4: // Count each grade that is above 80 in the list
                        displayNumbers(studentGrades);
                        int count = 0;
                        for (int i = 0; i < studentGrades.Count; i++)
                        {
                            if (studentGrades[i] > 80)
                            {
                                count++;
                            }
                        }
                        Console.WriteLine("The amount of students who have achieve honours is " + count + ".");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 5: // Exit
                        Console.Clear();
                        Console.WriteLine("Shutting down code now. Press any key to continue...");
                        Console.ReadKey();
                        break;
                    default: // return for things that aren't a part of the options
                        Console.WriteLine("Syntax error! That isn't an option that you can make.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
            while (choice != 5);
        }
    }
}
