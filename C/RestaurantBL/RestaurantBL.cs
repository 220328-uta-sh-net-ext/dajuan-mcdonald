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
        public interface RestaurantUI
        {
            void ShowRestaurantDetails()
            {
                Console.WriteLine(@$"

                Restaurant Details: "
                     
                );
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

            public string CompanyDetails
            {
                get => @$"
                    Company Name: {companyName}

                    Company Rating: {companyRating}
                    ";
            }

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