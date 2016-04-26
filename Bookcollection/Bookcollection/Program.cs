using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookcollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tell the user what is it
            Console.WriteLine("list of book");
            // offer different choises for the user to choose with the list with a break line 
            Console.WriteLine("press A to add a book,\n D to delete a book from the list,\n L to see your list of book,\n S to sort the list by Alphabetic order, \n X to exit the from the list. ");



            // User input
            string userInput = Console.ReadLine().ToUpper();


            // Declare a List
            List<string> myBookList = new List<string>() { "The Hunger Game", "The Green Line", "I let you go", "The girl on the train" };
            
            Console.WriteLine(" Press x to exit");
            // Create a do while Loop
            do
            {

                switch (userInput)
                {
                    case "A":
                        // ask the user to input a name
                        Console.WriteLine(" Type the name of the book you would like to add :");
                        //create a string for add book
                        string bookToAdd = Console.ReadLine();
                        //adding an item in the list
                        myBookList.Add(bookToAdd);

                        break;
                    case "D":
                        Console.WriteLine(" Type the name of the book you would like to delete :");
                        string deleteBook = Console.ReadLine();
                        myBookList.Remove(deleteBook);

                        break;
                    case "L":
                        // create a for loop to show the list of books
                        for (int i = 0; i < myBookList.Count; i++)
                        {
                            Console.WriteLine(myBookList[i]);
                        }
                        break;
                    case "S":
                        Console.WriteLine("in the sort option");
                        myBookList.Sort();
                        break;
                    default:
                        break;

                }//end switch

                // aske thre user what to do next
                Console.WriteLine("what would you like to do next? A, D, L, S or X?");
                userInput = Console.ReadLine().ToUpper();

            } while (userInput != "X");
            }// end of object
    }// end of class
}// end of namespace















