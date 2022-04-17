using System;
namespace Restaurant
{


//BL...
namespace RestaurantBL
{
    public class Restaurant
    {
        

    }
}
    

//UI...
namespace RestaurantUI
{
    public interface IRestaurantMenu
    {
       
        void Prompt();

        void GetUserInput();

    }
    public class RestaurantMenu : IRestaurantMenu
    {
        private string companyName;
        private int companyRating;
        private int op;

        public RestaurantMenu()
        {
            // opt = 0;
        }

        public void Prompt()
        {
            Console.WriteLine("Prompt Interface");
        }

        public RestaurantMenu(int option)
        {

            Console.WriteLine(@$"
                Welcome to Revature Restaurant Portal!

                Let's get started....n

                [options]

                - Press <2> to search
                - Press <1> to add your restaurant
                - Press <0> to exit
            ");

            // opt = option;

        }

    public void GetUserInput()
    {
        string userInput = Console.ReadLine();

    }

    public void showDetails()
    {
        Console.WriteLine(@$"
            Company Name: {companyName}

            Company Rating: {companyRating}
        ");
    }

    }
    
}    


//DL...
namespace RestaurantDL
{
        class RestaurantDL
        {



        }
    

}

//MODEL...
namespace RestaurantModels
{
// all operations -> as methods/behaviors
    
        public class RestaurantModels
        {
            int[] ratings = {0, 1, 2, 3, 4, 5};
            public string CompanyName
            {
               get => companyName;
               set {
                  if (string.IsNullOrWhiteSpace(value)) 
                    throw new ArgumentException("Company Name cannot be empty or null"); 
                    companyName = value;
               }
    
            }
            private string companyName;
            
            public int CompanyRating
            {
                   get => companyRating;
                   set {
                       if(value < ratings[0])
                        {
                            throw new ArgumentNullException("Rating must not be null");
                        }

                        if (value > 6)
                            {
                                throw new ArgumentOutOfRangeException("Rating must be 1-5");
                            }
                        companyRating = value;
                   }
            }
            private int companyRating;

            

            //initialize an object cause we can't have any null values
            
     
        public RestaurantModels()
        {
            CompanyName = "Coscos";
            CompanyRating = 4;

        }


        }
    
}
    class Program
    {
        public static void  Main()
        {
            
            Console.WriteLine("Restaurant");
            
            

        }
    }
}