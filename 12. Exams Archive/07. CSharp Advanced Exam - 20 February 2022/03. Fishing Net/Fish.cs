﻿namespace FishingNet
{
    public class Fish
    {
        //Properties
        public string FishType { get; private set; }
        public double Length { get; private set; }
        public double Weight { get; private set; }

        //Constructor
        public Fish(string fishType, double length, double weight)
        {
            FishType = fishType;
            Length = length;
            Weight = weight;
        }

        //Methods
        public override string ToString()
        {
            return $"There is a {FishType}, {Length} cm. long, and {Weight} gr. in weight.";
        }
    }
}
