using RestaurantModels;
using System;

namespace RestaurantBL
{
    public interface IRestaurantLogic
    {
        Restaurant AddRestaurant(Restaurant r);

        List<Restaurant> SearchRestaurant(string name);
    }
}
