using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week1Challenge
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NameAndAge()
        {
            string firstName = "Mike";
            string lastName = "Aguirre";
            int age = 29;
            Console.WriteLine(age + 7);
            Console.WriteLine(age - 7);
            Console.WriteLine(age * 7);
            Console.WriteLine(age / 7);
            Console.WriteLine(age % 7);
        }
        [TestMethod]
        public void Array()
        {
            string[] movies = { "Batman", "Little Nicky", "Beetlejuice", "Brothers" };

        }
        [TestMethod]
        public void ListOfDates()
        {
            List<DateTime> listOfDates = new List<DateTime>();
            DateTime today = DateTime.Now;
            listOfDates.Add(today);
            listOfDates.Add(new DateTime(2020, 11, 26));
            listOfDates.Add(new DateTime(2020, 12, 25));
            listOfDates.Add(new DateTime(2020, 12, 31));
            listOfDates.Add(new DateTime(2021, 1, 1));
        }
        [TestMethod]
        public void HowMuchSleepDidYouGet()
        {
            Console.WriteLine("How many hours of sleep did you get?");
            int hours = 4;
            if(hours >=10)
            {
                Console.WriteLine("Woww, that's alot of sleep!");
            }
            else if(hours >= 8 && hours < 10)
            {
                Console.WriteLine("You should be well rested");
            }
            else if(hours > 4 && hours < 8)
            {
                Console.WriteLine("Bummer...");
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }
        }
        [TestMethod]
        public void HowHasYourDayBeen()
        {
            string userDay = "Okay";
            switch(userDay)
            {
                case "Great":
                    Console.WriteLine("That's awesome!");
                    break;
                case "Good":
                    Console.WriteLine("Everyday above ground is a good day!");
                    break;
                case "Okay":
                    Console.WriteLine("I hope it gets better for you");
                    break;
                case "Bad":
                    Console.WriteLine("The grass is always greener on the other side");
                    break;
                case ":(":
                    Console.WriteLine("I guess this is us now");
                    break;
                default:
                    Console.WriteLine("Please input a response");
                    break;
            }
        }
        [TestMethod]
        public void Supercalifragilisticexpialidocious()
        {
            string name = "Supercalifragilisticexpialidocious";
            foreach(char letter in name)
            {
                if(letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("not an i");
                }    
            }
        }
    }
}
