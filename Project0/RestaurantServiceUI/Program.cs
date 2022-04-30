using RestaurantService;

bool repeat = true;
while(repeat)
{
    string reply = System.Console.ReadLine();

    switch (reply)
    {
        case "Search":
            //do something here
            System.Console.WriteLine("searching disabled til login satisfied");
            break;
        case "Login":
            //logging in is for admin and user
            System.Console.WriteLine("...................>>");
            break;
        case "Home" :
            //redirect via console
             
        case "Exit" : 
            repeat = false;
            break;

        default:
            System.Console.ReadLine();
            break;

    }
}
