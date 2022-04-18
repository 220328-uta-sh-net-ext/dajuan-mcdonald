using System;
using System.Collections.Generic;

namespace RestaurantApp
{
    public class Restaurant
    {
        private string m_restaurantName;
        private double m_rating;
        private string m_level;
        private double m_avg;

        private List<double> m_ratingsList = new List<double>();

        private Restaurant() {}
        //
        public Restaurant(double avg)
        {
            
            m_avg = avg;

        }

        public Restaurant(string restaurantName, double restaurantRating)
        {
            m_restaurantName = restaurantName;
            m_rating = restaurantRating;
        }

        public double RatingsList
        {
            get => m_ratingsList.Count;

        }

        public string GetRestaurantName
        {
            get => m_restaurantName;
        }

        public string SetRestaurantName
        {
            set => m_restaurantName = value;
        }

        public double GetRating 
        {
            get => m_rating;
        }

        public double SetRating
        {
            set => m_rating = value;
        }

        public double ShowAverage
        {
            get => m_avg;
        }

        public void UpgradeRating(double rating)
        {
            if(rating <= 5)
            {
                m_rating += rating;

            }
            else
            {
                throw new ArgumentException(nameof(rating), "Rating exceeds allowed value.");

            }
        }

        public static void Main()
        {
            Restaurant a = new Restaurant("Billies", 2);
            

            // a.m_level = "low";
            a.m_avg = 2.0;

            Console.WriteLine(@$"
               {a.m_restaurantName} has a {a.m_rating} Star rating.
               
               The average rating is {a.m_avg}.
               ");
        }

    }
}
