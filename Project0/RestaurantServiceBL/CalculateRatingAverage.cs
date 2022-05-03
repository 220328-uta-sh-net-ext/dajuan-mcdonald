using System.Collections.Generic;
using RestaurantService;

namespace RestaurantServiceBL
{
   public class CalculateRatingAverage : IService
   {
      private const double MAXRATING = 5.0;

      public void CalculateAvg(List<double> ratings)
      {
         int size = 0;                                                       
         double sum = 0;                                                    
         double avg = sum / size;                                           

          foreach (var rate in ratings)                                         
           {                                                                   
               size += 1;                                                       
               sum += rate;                                                     
                                                                                
           }                                                                   
                                                                                
        System.Console.WriteLine(avg);
         
      }

      // public virtual decimal GetAvgRatingScore(List<decimal> rates)
      // {
      //    int size = 0;
      //    decimal sum = 0;
      //    decimal avg = sum / size;
      //
      //    foreach (var rate in rates)
      //    {
      //       size += 1;
      //       sum += rate;
      //       
      //    }
      //
      //    return avg;
      // }
   }
}
