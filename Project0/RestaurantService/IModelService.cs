namespace RestaurantService
{
    interface IServiceInterface
    {
        //properties
        string Name {get; set;}
        decimal Rating {get; set;}
        string Review {get; set;}

        string UserPassword {set;}
        string UserName {get; set;}




        //methods
        void SearchBusinessBy();
        void SearchBusinessMethod();
        void AddNewUser();
        void SearchUserAsAdmin();
        void AddReview();

    }
}