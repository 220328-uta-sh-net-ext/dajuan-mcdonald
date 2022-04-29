namespace RestaurantService;
class Service : IServiceInterface
{
    public string Name {get; set;}
    public decimal Rating {get; set;}
    public string Review {get; set;}

    void IServiceInterface.AddReview()
    {

    }


}
