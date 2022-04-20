using System;
using RestaurantUI;

bool prompt = true;
string promptStatement = "Make a choice !";
IRestMenu restMenu = new MainMenu();

while (prompt)
{
    restMenu.Display();
    string response = restMenu.GetUserChoice();

    switch (response)
    {
        case "Exit":
            prompt = false;
            break;

    }
}






