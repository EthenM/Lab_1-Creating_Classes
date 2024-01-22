using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1___Creating_Classes
{

    public enum RelationShipTypes
    {
        Sister,
        Brother,
        Mother,
        Father
    }

    internal class Relation
    {
        private RelationShipTypes RelationShipType { get; }

        /// <summary>
        /// Stores a relationship type between people
        /// </summary>
        /// <param name="type">The type of relationship to store</param>
        public Relation(RelationShipTypes type) 
        {
            //this will store the type of relationship the instance will hold
            RelationShipType = type;
        }

        /// <summary>
        /// Takes two people and displays the nature of their relationship
        /// </summary>
        /// <param name="firstPerson">The first person to display</param>
        /// <param name="secondPerson">The second person to display</param>
        public void ShowRelationship(Person firstPerson, Person secondPerson)
        {
            string relationString = "";

            //figure out which string to use
            //there shouldn't be another case, as this class needs a value from the RelationShipTypes enum
            switch (RelationShipType)
            {
                case RelationShipTypes.Sister:
                    relationString = "Sisterhood";
                    break;
                case RelationShipTypes.Brother:
                    relationString = "Brotherhood";
                    break;
                case RelationShipTypes.Mother:
                    relationString = "Motherhood";
                    break;
                case RelationShipTypes.Father:
                    relationString = "Fatherhood";
                    break;
            }

            //now that the relationString has been filled, print the relationship between the two people
            Console.WriteLine($"Relationship between {firstPerson.FirstName} and {secondPerson.FirstName} is: {relationString}");
        }
    }
}
