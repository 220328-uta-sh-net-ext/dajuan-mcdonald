namespace RestaurantService{

public class Review
{

    //constructor
    public Review()
    {
        name = "Restaurant Exile";
        review = "This place rocks! Eat here often!";
        rating = 5.0;
        author = "Tester";
 //       date = DateTime.Now;
        
    }


    //name string
    public string name {get => name; set => name = value;}

    public string review {get => review; set => review = value;}
    

    //datetime
  //  public date {get => Datetime.Now ; set = date = Datetime.Now;}


    //ratings double
    private double rating;
    public double Rating {
        get => rating; 
        set {
            if(value >= 0 && value <= 5.0)
                rating = value;
            else
                throw new ArgumentException("provided value is not valid.");
            
            } 
        }

    
    //author string
    private string author {get; set;}
    public string Author {
        get => author;

        set => author = value;
    }


    
}
}
