using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1___Creating_Classes
{
    internal class Person
    {
        private int PersonId { get; }
        public string FirstName { get; }
        private string LastName { get; }
        private string FullName { get; }
        public Colours FavouriteColour { get; private set; }
        public int Age { get; }
        private bool IsWorking { get; }

        /// <summary>
        /// Creates a new person, with some basic information
        /// </summary>
        /// <param name="personId">The new person's id</param>
        /// <param name="firstName">The new person's first name</param>
        /// <param name="lastName">The new person's last name</param>
        /// <param name="favouriteColour">The new person's favourite colour</param>
        /// <param name="age">The new person's age</param>
        /// <param name="isWorking">Whether or not the person is working</param>
        public Person(int personId, string firstName, string lastName, Colours favouriteColour, int age, bool isWorking = false)
        {
            PersonId = personId;
            FirstName = firstName;
            LastName = lastName;
            FavouriteColour = favouriteColour;
            Age = age;
            IsWorking = isWorking;

            //this way we have the full name for some of the other methods
            FullName = FirstName + " " + lastName;
        }

        /// <summary>
        /// Displays the person's information in a sentence
        /// </summary>
        public void DisplayPersonInfo()
        {
            //display the person's info
            Console.WriteLine($"{PersonId}: {FullName}'s favourite colour is: {FavouriteColour}");
        }

        /// <summary>
        /// Changes the favourite colour property of the instance
        /// </summary>
        /// <param name="newColour">The new favourite colour</param>
        public void ChangeFavouriteColour(Colours newColour)
        {
            FavouriteColour = newColour;
        }

        /// <summary>
        /// Displays the age of the person in ten years
        /// </summary>
        public void GetAgeInTenYears()
        {
            int ageInTenYears = Age + 10;


            Console.WriteLine($"{FullName}'s age in 10 years is: {ageInTenYears}");
        }

        public override string ToString()
        {
            string output = $"PersonId: {PersonId}\nFirstName: {FirstName}\nLastName: {LastName}" +
                $"\nFavouriteColour: {FavouriteColour}\nAge: {Age}\nIsWorking: {IsWorking}";

            return output;
        }
    }
}
