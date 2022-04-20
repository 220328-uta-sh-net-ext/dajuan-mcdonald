namespace RestaurantUI
{
      class MainMenu : IRestMenu
      {
            public void Display()
            {
                  Console.WriteLine(@"
         Welcome to RevRestaurant App!

         What would you be interested in doing first?
         Make a selection from the options menu

         options:
         ---------------------------------------|
               <0> | Exit Menu                  |
         ---------------------------------------
               <1> | Add a Rating               |
        ----------------------------------------|
               <2> | Add a Restaurant           |
         ----------------------------------------
               <3> | Show existing Restaurants  |
         ---------------------------------------|
               <4> | Search                     |
         ");

            }

            public string GetUserChoice()
            {
                  string userInput = Console.ReadLine();

                  switch (userInput)
                  {
                        case "0":
                              return "Exit";
                        default:
                              return "MainMenu";

                  }
            }
      }
}
