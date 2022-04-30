namespace RestaurantService;

public class Restaurant : IRestaurant
{
    public string Name { get; set; }
    public decimal Rating { get; set; }
    
    public string Review { get; set; }

    public void AddRating(decimal rating)
    {
        
    }

    public void AddReview(string review)
    {
        
    }

    public void SearchByRating(decimal rating)
    {
        
    }

    public void SearchByName(string name)
    {
        
    }

    public void PrintDetails(string resName)
    {
        
    }
}