using System;

namespace RestaurantApp
{
    public class Restaurant
    {
        private readonly string m_restaurantName;
        private double m_rating;

        private Restaurant() {}

        public Restaurant(string restaurantName, double restaurantRating)
        {
            m_restaurantName = restaurantName;
            m_rating = restaurantRating;
        }

        public string RestaurantName
        {
            get => m_restaurantName;
        }

        public double Rating 
        {
            get => m_rating;
        }

        public void Rate(double rating)
        {
            m_rating += rating;
        }


        public static void Main()
        {
            Restaurant a = new Restaurant("Billies", 2);
            Console.WriteLine(a.m_rating);
        }

    }
}
