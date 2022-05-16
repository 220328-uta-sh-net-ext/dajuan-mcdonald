using System.Collections.Generic;
using RestaurantService;

namespace RestaurantServiceBL
{
   public class CalculateRatingAverage
   {
      private const double MAXRATING = 5.0;

      public double CalculateAvg(List<double> ratings)
      {
         int size = 0;                                                       
         double sum = 0;                                                    
         double avg = sum / size;                                           

          foreach (var rate in ratings)                                         
           {                                                                   
               size += 1;                                                       
               sum += rate;                                                     
                                                                                
           }                                                                   
                                                                                
        return avg;
         
      }

   }
}
