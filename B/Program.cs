// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Ubuntu!");

Console.WriteLine("Hello, World!");

Console.WriteLine(15 % 30);

string userName = "fiopwk";


// Basic string formatting in C#
string repo = $@"220328-uta-sh-net-ext/{userName}";
Console.WriteLine(repo);


//Math Operators
string numbers = 7 + " and " + 5;

int sum = (7 + 5);
int difference = (7 - 5);
int product = (7 * 5);
decimal quotient = (7.0m / 5);
decimal otherQuotient = (7.0m / 5.0m);

//remainder int division with modulus
Console.WriteLine((sum % product));

//Casting a data type
/*
 * Casting is one type of data conversion that instructs the compiler to temporarily 
 * treat a value as if it were a different data type.
 * 
 * To cast int to decimal, you add the cast operator before the value. 
 * You use the name of the data type surrounded by parenthesis in front of the value to cast it.
 *
 *
 * */


decimal newQuotient = ((decimal)sum / (decimal)product);


