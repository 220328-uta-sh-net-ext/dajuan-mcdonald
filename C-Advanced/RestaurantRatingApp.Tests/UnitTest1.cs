using Xunit;

namespace RestaurantRatingApp.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        int a = 10, b = 20, expected = 30;
        Assert.Equal(expected, 30);

    }
}