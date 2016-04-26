using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace language
{
    class Program
    {
        static void Main(string[] args)
        {
            // Explain the user what is it 
            Console.WriteLine(" Welcome to the dictionary of computer language");

            // offer different choises for the user to choose with the list with a break line 
            Console.WriteLine("Type K to search, \n type D for description \n type C to count the number of items in the dictionary\n type x to exit ");
            // User input
            string userInput = Console.ReadLine().ToUpper();

            // Declare the dictionary function
            Dictionary<string, string> definition = new Dictionary<string, string>();
            //Adding item to the dictionary
            definition.Add("C#", "The best programming in the world.");
            definition.Add("JavaScript", " was created in 10 days");
            definition.Add("Java", "A small team of engineers, known as the Green Team, initiated the language in 1991.");

            //Create a do while loop for user to have choices
            do
            {//star of do

                switch (userInput)
                { // start of switch

                    case "K":
                        // Tell the user to input a key
                        Console.WriteLine("Please enter the key:");
                        string key = Console.ReadLine();
                        if(definition.ContainsKey(key))
                        {
                            Console.WriteLine(key + " is in the dictionary");
                        }
                        
                                 break;

                    case "D":

















                        Console.WriteLine("Please enter a decription:");
                        string value = Console.ReadLine();
                        if (definition.ContainsValue(value))
                             { 
                            Console.WriteLine( value + "is in the dictionary");
                        }
                        break;

                    case "C":
                        
                        int count = definition.Count();
                        Console.WriteLine("There are " + count + " entries in the dictionary");
                        
                        break;
                    default:
                        break;

                }// end of switch

                Console.WriteLine("what would you like to do next? K, D, C or X?");
               userInput = Console.ReadLine().ToUpper();
           
            } while (userInput != "X");
           



            // }//end of while
        }//end of object
    }// end of class

}//end of namespace