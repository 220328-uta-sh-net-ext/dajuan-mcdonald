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


/*
 *
 * While there is no 'exponent' operator in C#,
 * you can use the System.Math.Pow() method from the .NET
 * Class Library.
 *
 * The order of operations in C# follows the PEMDAS acronym
 *
 *
 * */
int value1 = 3 + 4 * 5; // 23
int value2 = (3 + 4) * 5; // 35


// Increment and Decrement Values

int value = 0;
value += 5;

value++;

Console.WriteLine(value); // should be 6


/*
 *Compound assignment operators:
 += , -=, *=, ++, -- 
 *
 *
 * */

int variable1 = 1;

variable1 = variable1 + 1;
Console.WriteLine("First increment: " + variable1); // 2

variable1 += 1;
Console.WriteLine("Second increment: " + variable1); // 3

variable1++;
Console.WriteLine("Third increment: " + variable1); // 4

variable1 = variable1 - 1;
Console.WriteLine("First decrement: " + variable1); // 3

variable1 -=1;
Console.WriteLine("Second decrement: " + variable1); // 2

variable1--;
Console.WriteLine("Third decrement: " + variable1); // 1

//fehrenheit to celcius
int fahrenheit = 94;

decimal toCelsius = ((decimal)fahrenheit - (decimal)32) * 5/9;

Console.WriteLine(toCelsius);

