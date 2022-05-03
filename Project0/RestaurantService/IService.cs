namespace RestaurantService
{
    public interface IService
    {
        void CalculateAvg(List<double> ratings);


    }

    public interface IUser
    {
        void SearchUsers(string username);
        void AddUser(string username, string userpass);

    }

    public interface IRestaurant
    {
        void AddRating(double rating);
        
        void SearchByRating(double rating);
        void SearchByName(string name);
        void PrintDetails(string resName);
        

    }

    public interface IReview
    {
        void AddReview(string review);

        void PrintReview(string review);
    }
}

