using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace LibraryCardCatalog
{
    class Program1
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome Costumer!");

            UserNameInput();

            Console.ReadLine();
        }

        static private void UserNameInput()
        {
            Console.WriteLine("PLEASE REMEMBER THE NAME OF THE FILE!");

            Console.Write("Please input the name of a file: ");
            string fileName = Console.ReadLine();

            CardCatalog cardCatalog = new CardCatalog(fileName);

            PromptMenuForUser(cardCatalog);
        }

        static private void PromptMenuForUser(CardCatalog cardCatalog)
        {
            int userChoice;

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. List All Books\n" +
                    "2. Add A Book\n" +
                    "3. Save And Exit");

                Console.Write("Input your choice: ");

                if (int.TryParse(Console.ReadLine(), out userChoice))
                {
                    if (userChoice == 1)
                    {
                        //List all the books 
                        //replay the menu
                        cardCatalog.ListBooks();

                    }
                    else if (userChoice == 2)
                    {
                        //Add a book to the userfile
                        //replay the menu
                        cardCatalog.AddBook();

                    }
                    else if (userChoice == 3)
                    {
                        //Save all the books added to the userfile
                        //close the menu
                        cardCatalog.Save();
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please choose from the above!\n" +
                            "Thank you!");
                    }
                }



            }
        }



    }

}

