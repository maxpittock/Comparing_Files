using System;
using System.IO;

namespace Comparing_Files
{
    class Program
    {
        //global variables allowing me to store which txt the user picks to compare
        public static string input_result1 = "";
        public static string input_result2 = "";

        
      
        static void Main(string[] args)
        {
            //Telling the user what the program will do
            Console.WriteLine("In this program you have to select two text files and the console will tell you if the content within those files are the same or not.");
            //provides the user the correct commands to type in to select a particular text file
            Console.WriteLine("To select your first choice type one of these 6 options\none_a\none_b\ntwo_a\ntwo_b\nthree_a\nthree_b");
            //calls the First_option function which asked for the users input and handles the first choice
            First_Option();
            Console.WriteLine("To select your second choice type one of these 6 options\none_a\none_b\ntwo_a\ntwo_b\nthree_a\nthree_b");
            //calls the Second_option function which asked for the users input and handles the second choice
            Second_Option();
            //Calling the file similarity function to compare the users choices.
            File_similairty();
            //Calls the compare length function.
            CompareLength();
 
        }
        //first option function definition
        public static string First_Option()
        {
            //asking the user for a string input
            string Input1 = Console.ReadLine().ToLower();

            ///Summary
            ///uses the users input to select a specfic text file this is then stored in input_result1 a global variable that stored the selected string for the first option
            ///
            if (Input1 == "one_a")
            {
                //importing the text file into the variable.
                input_result1 = File.ReadAllText("GitRepositories_1b.txt");
            }
            else if (Input1 == "one_b")
            {
                input_result1 = File.ReadAllText("GitRepositories_1b.txt");
            }
            else if (Input1 == "two_a")
            {
                input_result1 = File.ReadAllText("GitRepositories_2a.txt");
            }
            else if (Input1 == "two_b")
            {
                input_result1 = File.ReadAllText("GitRepositories_2b.txt");
            }
            else if (Input1 == "three_a")
            {
                input_result1 = File.ReadAllText("GitRepositories_3a.txt");
            }
            else if (Input1 == "three_b")
            {
                input_result1 = File.ReadAllText("GitRepositories_3b.txt");
            }
            else
            {
                //if the input isnt defined by the if statements above then the input must be incorrect so throw this error
                Console.WriteLine("Wrong Input");
                //if the input is incorrect exit console.
                Environment.Exit(0);
            }
            //something had to be returned here
            return null;
               
        }
        //second option function definition
        public static string Second_Option()
        {
           
            string Input2 = Console.ReadLine().ToLower();
            
            if (Input2 == "one_a")
            {
                input_result2 = File.ReadAllText("GitRepositories_1b.txt");
            }
            else if (Input2 == "one_b")
            {
                input_result2 = File.ReadAllText("GitRepositories_1b.txt");
            }
            else if (Input2 == "two_a")
            {
                input_result2 = File.ReadAllText("GitRepositories_2a.txt");
            }
            else if (Input2 == "two_b")
            {
                input_result2 = File.ReadAllText("GitRepositories_2b.txt");
            }
            else if (Input2 == "three_a")
            {
                input_result2 = File.ReadAllText("GitRepositories_3a.txt");
            }
            else if (Input2 == "three_b")
            {
                input_result2 = File.ReadAllText("GitRepositories_3b.txt");
            }
            else
            {
                Console.WriteLine("Wrong Input");
                Environment.Exit(0);
            }
            return null;
        }
        //defining the comparing function
        public static void File_similairty()
        {
            //if the strings that have been inputed into both global variables is the same then...
            if (input_result1 == input_result2)
            {
                //...print this message to console
                Console.WriteLine("These files are the same");
            }
            //if they arent the same...
            else
            {
                //...print this error message to console.
                Console.WriteLine("These files are different");
            }
        }
        //defining the comapre length function
        public static void CompareLength()
        {
            //if the length of the two global variables is the same then...
            if (input_result1.Length == input_result2.Length)
            {
                //print this message to the console
                Console.WriteLine("The length of these files is the same");
            }
            //if the length of the variables are different then...
            else
            {
                //print this error message to console
                Console.WriteLine("The length of these files is not the same");
            }
        }
    

    }
}
