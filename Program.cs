using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1___Creating_Classes
{

    public enum Colours { Blue, Red, Green, Yellow, Purple, Black, White };

    internal class Program
    {
        public static void Main(string[] args)
        {
            //create four people objects
            Person ian = new(1, "Ian", "Brooks", Colours.Red, 30, true);
            Person gina = new(2, "Gina", "James", Colours.Green, 18);
            Person mike = new(3, "Mike", "Briscoe", Colours.Blue, 45, true);
            Person mary = new(4, "Mary", "Beals", Colours.Yellow, 28, true);

            List<Person> people = new() { ian, gina, mike, mary };

            //this will display Gina's info as a sentence
            gina.DisplayPersonInfo();

            //this will display Mike's info as a list
            Console.WriteLine(mike.ToString());

            //change Ian's colour to white, then print his info as a sentence
            ian.ChangeFavouriteColour(Colours.White);
            ian.DisplayPersonInfo();

            //get Mary's age in ten years
            mary.GetAgeInTenYears();

            //here will lie the relation objects
            Relation sistersRelation = new(RelationShipTypes.Sister);
            Relation brothersRelation = new(RelationShipTypes.Brother);

            sistersRelation.ShowRelationship(gina, mary);
            brothersRelation.ShowRelationship(ian, mike);

            //these are nullible to get rid of the warnings regarding to setting their values to null
            Person? oldestPerson = null;
            Person? youngestPerson = null;
            Person? whoLikesBlue = null;
            int totalAge = 0;
            List<Person> namesWithM = new();

            //loop through the list and complete the rest of the tasks
            foreach (Person person in people)
            {
                //first check for the oldest and youngest
                //ensure that the variables get filled on the first run as well by checking for a null value
                if (oldestPerson == null || oldestPerson.Age < person.Age)
                {
                    oldestPerson = person;
                }

                if (youngestPerson == null || youngestPerson.Age > person.Age)
                {
                    youngestPerson = person;
                }

                //add to the total age so that an average can be calculated afterwards
                totalAge += person.Age;

                //here will check the name to see if it starts with M
                string firstLetter = person.FirstName.Substring(0, 1).ToUpper();

                if (firstLetter == "M")
                {
                    namesWithM.Add(person);
                }

                //check if the person likes blue
                if (person.FavouriteColour == Colours.Blue)
                {
                    whoLikesBlue = person;
                }
            }

            //get the average age of the people on the list
            //one of the two numbers needs to be converted to a float to ensure
            //the result is a float
            float averageAge = (float)totalAge / people.Count;

            Console.WriteLine($"Average age is: {averageAge}");
            Console.WriteLine($"The youngest person is: {youngestPerson?.FirstName}");
            Console.WriteLine($"The oldest person is: {oldestPerson?.FirstName}");

            foreach (Person person in namesWithM)
            {
                Console.WriteLine(person.ToString());
            }

            //display the information of the person who likes the colour blue
            Console.WriteLine(whoLikesBlue?.ToString());
        }
    }
}
