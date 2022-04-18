namespace RestaurantRatingApp.Tests
{
    public class RestaurantRatingProcessTests
    {
        [Fact]
        public void ShouldReturnRatingWithRequestedValues()
        {
            var rating = new RestaurantRatingApp();
            var request = new RestaurantRatingRequest
            {
                BusinessName = "Alibaba",
                Location = "Rhode Island",
                Email = "alibaba@fake.org",
                StarRating = 4
            };

            RestaurantRatingRequest response = rating.Show(request);

        
        }
    }
}