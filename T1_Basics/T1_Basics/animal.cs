using System;
namespace T1_Basics
{
    public class animal
    {
        private string name;
        private string foodType;

        //static variables
        public static int animalCounter;

        public animal(string name, string foodType)
        {
            this.name = name;
            this.foodType = foodType;
            animalCounter++;
        }

        //New method
        public String Name
        {
            get { return this.name; }

            set { this.name = value; }
        }

        //Traditional setters and getters
        //public string getName()
        //{
        //    return this.name;
        //}

        //private void setName(string name)
        //{
        //    this.name = name;
        //}

    }
}

