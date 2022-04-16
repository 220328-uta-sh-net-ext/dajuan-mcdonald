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
    class RestaurantMenu : IRestaurantMenu
    {
        public void Prompt()
        {
            Console.WriteLine(@$"
                Welcome to Revature Restaurant Portal!

                Let's get started....n

                [options]

                - Press <2> to search
                - Press <1> to add your restaurant
                - Press <0> to exit
            ");
        }

    public void GetUserInput()
    {
        string userInput = Console.ReadLine();

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
    
        class RestaurantModels
        {
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
                   set => companyRating = value;
            }
            private int companyRating;

            

            //initialize an object cause we can't have any null values
            
     
        public void LocalShop()
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