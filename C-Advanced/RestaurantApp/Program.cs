using System;

namespace RestaurantApp
{
    public class Restaurant
    {
        private readonly string m_restaurantName;
        private int m_rating;

        private Restaurant() {}

        public Restaurant(string restaurantName, int restaurantRating)
        {
            m_restaurantName = restaurantName;
            m_rating = restaurantRating;
        }

        public string RestaurantName
        {
            get => m_restaurantName;
        }

        public int Rating 
        {
            get => m_rating;
        }

        public void Rate(int rating)
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
