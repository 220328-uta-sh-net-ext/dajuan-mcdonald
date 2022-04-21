namespace RestaurantModels
{
    public class Restaurant
    {
        private string Name {get; set;}
        private double Rating {get; set;}
        
        public Restaurant()
        {
            Name="?";
            Rating=0.0;


        }
        public override string ToString()
        {
            return $@"
            Name: {Name}
            Rating: {Rating}
                 
                ";
        }

        
    }

    
}
