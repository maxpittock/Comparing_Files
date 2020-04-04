using System;
using System.IO;

namespace Comparing_Files
{
    class Program
    {
        //global variables allowing me to store which txt the user picks to compare
        public static string input_result = "";
        public static string input_result1 = "";
        public static string input_result2 = "";

        
      
        static void Main(string[] args)
        {
            //Telling the user what the program will do
            Console.WriteLine("In this program you have to select two text files and the console will tell you if the content within those files are the same or not.");
            //provides the user the correct commands to type in to select a particular text file
            call_Functions();
 
        }
        public static void call_Functions()
        { 
            Console.WriteLine("To select your first choice type one of these 6 options\none_a\none_b\ntwo_a\ntwo_b\nthree_a\nthree_b");
            //calls the Choose_Files function which asked for the users input and handles the first choice
            Choose_Files();
            //Makes input_result1 contain thee content the user selected
            input_result1 = input_result;
            //clears the input_result variable
            input_result = " ";
            Console.WriteLine("To select your second choice type one of these 6 options\none_a\none_b\ntwo_a\ntwo_b\nthree_a\nthree_b");
            Choose_Files();
            input_result2 = input_result;   
            //Calling the file similarity function to compare the users choices.
            File_similairty();
            //Calls the compare length function.
            CompareLength();
        }
        //first option function definition
        public static string Choose_Files()
        {

            //asking the user for a string input
            string Input = Console.ReadLine().ToLower();
            ///Summary
            ///uses the users input to select a specfic text file this is then stored in input_result1 a global variable that stored the selected string for the first option
            ///
            if (Input == "one_a")
            {
                //importing the text file into the variable.
                input_result = File.ReadAllText("GitRepositories_1b.txt");
            }
            else if (Input == "one_b")
            {
                input_result = File.ReadAllText("GitRepositories_1b.txt");
            }
            else if (Input == "two_a")
            {
                input_result = File.ReadAllText("GitRepositories_2a.txt");
            }
            else if (Input == "two_b")
            {
                input_result = File.ReadAllText("GitRepositories_2b.txt");
            }
            else if (Input == "three_a")
            {
                input_result = File.ReadAllText("GitRepositories_3a.txt");
            }
            else if (Input == "three_b")
            {
                input_result = File.ReadAllText("GitRepositories_3b.txt");
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
using System;
using System.IO;

namespace Comparing_Files
{
    class Program
    {
        //global variables allowing me to store which txt the user picks to compare
        public static string input_result = "";
        public static string input_result1 = "";
        public static string input_result2 = "";

        
      
        static void Main(string[] args)
        {
            //Telling the user what the program will do
            Console.WriteLine("In this program you have to select two text files and the console will tell you if the content within those files are the same or not.");
            //provides the user the correct commands to type in to select a particular text file
            call_Functions();
 
        }
        public static void call_Functions()
        { 
            Console.WriteLine("To select your first choice type one of these 6 options\none_a\none_b\ntwo_a\ntwo_b\nthree_a\nthree_b");
            //calls the Choose_Files function which asked for the users input and handles the first choice
            Choose_Files();
            //Makes input_result1 contain thee content the user selected
            input_result1 = input_result;
            //clears the input_result variable
            input_result = " ";
            Console.WriteLine("To select your second choice type one of these 6 options\none_a\none_b\ntwo_a\ntwo_b\nthree_a\nthree_b");
            Choose_Files();
            input_result2 = input_result;   
            //Calling the file similarity function to compare the users choices.
            File_similairty();
            //Calls the compare length function.
            CompareLength();
        }
        //first option function definition
        public static string Choose_Files()
        {

            //asking the user for a string input
            string Input = Console.ReadLine().ToLower();
            ///Summary
            ///uses the users input to select a specfic text file this is then stored in input_result1 a global variable that stored the selected string for the first option
            ///
            if (Input == "one_a")
            {
                //importing the text file into the variable.
                input_result = File.ReadAllText("GitRepositories_1b.txt");
            }
            else if (Input == "one_b")
            {
                input_result = File.ReadAllText("GitRepositories_1b.txt");
            }
            else if (Input == "two_a")
            {
                input_result = File.ReadAllText("GitRepositories_2a.txt");
            }
            else if (Input == "two_b")
            {
                input_result = File.ReadAllText("GitRepositories_2b.txt");
            }
            else if (Input == "three_a")
            {
                input_result = File.ReadAllText("GitRepositories_3a.txt");
            }
            else if (Input == "three_b")
            {
                input_result = File.ReadAllText("GitRepositories_3b.txt");
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
