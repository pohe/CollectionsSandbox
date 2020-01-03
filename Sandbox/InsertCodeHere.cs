using System;
using System.Collections.Generic;

namespace Sandbox
{
    public class InsertCodeHere
    {

        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            int[] talArray; //Erklæring
            talArray = new int[10];

            talArray[7] = 100; //tildeler værdien 100 til index plads 7
            talArray[0] = 10;
            talArray[1] = 5;
            talArray[2] = 4;
            talArray[3] = 7;
            
            talArray[5] = talArray[0] + talArray[1];

            Console.WriteLine($"På plads 5 ligger {talArray[5]}");

            //Gennemløb arrayet og læg 20 ind på alle pladser

            for (int i = 0; i < talArray.Length; i++)
            {
                talArray[i] = 20;
            }
            
            //Gennemløb talarray og udskriv indholdet
            Console.WriteLine("Udskrivning af TalArray");
            int index = 0; 
            foreach (int tal in talArray)
            {
                Console.WriteLine($"Indhold er {tal} på plads {index }");
                index++;
            }


            string[] names = new string[4];
            names[0] = "Arsen";
            names[1] = "Nicolai";

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Book[] bookArray = new Book[5];

            bookArray[0] = new Book("1234", "C# programming", "John Sharp");

            //List
            List<Book> bookList = new List<Book>();
            Book b1 = new Book("1234", "C# programming", "John Sharp");
            Book b2 = new Book("5656", "Python programming", "John Python");

            bookList.Add(b1);
            bookList.Add(b2);
            Console.WriteLine("Udskrivning af listen");
            foreach (Book book in bookList)
            {
                Console.WriteLine(book.ToString());
            }

            //Hvordan fjernes et objekt fra listen?
            //Hvordan checkes om der er en bestemt book i listen?


            //Dictioanry

            Dictionary<string, Book> bookDictionary = new Dictionary<string, Book>();

            bookDictionary.Add(b1.Isbn, b1);
            bookDictionary.Add(b2.Isbn, b2);

            //Udskrive

            //Fjerne  elementer

            //Checke om objekt forekommer i dictionary

            //Console.WriteLine("Hello world!");

            // The LAST line of code should be ABOVE this line
        }
    }
}