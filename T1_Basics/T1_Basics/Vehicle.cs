using System;
namespace T1_Basics
{
    public abstract class Vehicle
    {
        private string brandName;
        private int maxSpeed;

        public Vehicle(string brand, int speed)
        {
            brandName = brand;
            maxSpeed = speed;
        }

        public string BrandName
        {
            get { return brandName; }

            set { brandName = value; }
        }

        public int MaxSpeed
        {
            get { return maxSpeed; }

            set { maxSpeed = value; }
        }
    }
}

