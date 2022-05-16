using Xunit;
using RestaurantServiceBL;

namespace Tests{

public class UnitTest1
{
    [Fact(Skip="Test Azure SQL Server is Active")]
    public void TestConnectionIsCalled()
    {
       // var dbRequest = new Connection();
    }

    [Fact(Skip="Test Add Rating Is Called Once skipped.")]
    public void TestAddRatingsIsCalled()
    {
       // var request = new AddRating();

    }

    
    [Fact(Skip="Test Search Users Is Called skipped.")]
    public void TestSearchUsersIsCalled()
    {
       // var request = new SearchUsers();

    }


    [Fact(Skip="Test Add Review Is Called Once skipped")]
    public void TestAddReviewIsCalledOnce()
    {
       // var request = new AddReview();

    }

    [Fact(Skip="Test Add New User Is Called Once skipped")]
    public void TestAddNewUserIsCalledOnce()
    {
       // var request = new AddUser();

    }

    [Fact(Skip="Test Search Business By Name Is Called Once skipped")]
    public void TestSearchBusinessByNameIsCalledOnce()
    {
        //var response = new SearchByName();
    }

    [Fact(Skip="Test Search Business By Rating Is Called Once skipped")]
    public void TestSearchBusinessByIsCalledOnce()
    {
       // var request = new SearchByRating();

    }

    [Fact(Skip="Test Calculate Ratings Average Is Called Once skipped")]
    public void TestCalculateAverageIsCalledOnce()
    {
       // var request = new CalculateAvg();

    }
}
}
