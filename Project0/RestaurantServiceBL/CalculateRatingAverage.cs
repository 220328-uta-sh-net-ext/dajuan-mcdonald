using System.Collections.Generic;
using RestaurantService;

namespace RestaurantServiceBL
{
   public class CalculateRatingAverage : IService
   {
      private const decimal MAXRATING = 5.0;

      public void CalculateAvg(List<decimal> ratings)
      {
         //calculate ratings average
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