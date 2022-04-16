namespace RestaurantModel
{
    public class Restaurant
    {
        public string CompanyName 
        {
            get => companyName;
            set
            {
                if(string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Emply company name not allowed!");

                companyName = value;

            };
        }

        public int CompanyRating
        {
            get => companyRating; //TODO: make the logic for this in BL
            set => companyRating = value;
        }

        public CompanyName()
        {
            companyName = "Namerals";
            companyRating = 0;

        }

    }
}
