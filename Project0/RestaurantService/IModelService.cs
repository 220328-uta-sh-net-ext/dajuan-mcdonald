namespace RestaurantService
{
    interface IServiceInterface
    {
        void SearchBusinessBy();
        void SearchBusinessMethod();
        void AddNewUser();
        void SearchUserAsAdmin();
        void AddReview();

    }
    class IModelService : IServiceInterface
    {
        

    }
}