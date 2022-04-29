namespace RestaurantService;
public class Service : IServiceInterface
{
    public string _review = "??";
    public decimal _rating = 5m;

    public string _name = "???";
    public string _username = "???";
    private string _password = "password";

    //read-write instance property
    string IServiceInterface.Name
    {
        get => _name;
        set => _name = value;
    }

    decimal IServiceInterface.Rating
    {
        get => _rating;
        set => _rating = value;
    }

    string IServiceInterface.Review
    {
        get => _review;
        set => _review = value;
    }

    string IServiceInterface.UserName
    {
        get => _username;
        set => _username = value;
    }

    string IServiceInterface.UserPassword
    {
        set => _password = value;
    }

    void IServiceInterface.AddReview()
    {
        

    }

    void IServiceInterface.SearchBusinessBy()
    {

    }

    void IServiceInterface.SearchBusinessMethod()
    {
        
    }

    void IServiceInterface.AddNewUser()
    {

    }

    void IServiceInterface.SearchUserAsAdmin()
    {

    }


}
