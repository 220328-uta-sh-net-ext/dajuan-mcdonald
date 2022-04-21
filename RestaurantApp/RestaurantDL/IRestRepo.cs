using RestaurantModels;

namespace RestaurantDL
{
    public interface IRestRepo
    {
        Restaurant AddRestaurant(Restaurant rest);

        List<Restaurant> ShowAllRestaurants();
    }
}
