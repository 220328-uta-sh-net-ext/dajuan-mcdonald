// See https://aka.ms/new-console-template for more information
using System;


string gameName="Thanks for playing! Random Game: No ordinary game!";
string winningMessage="Winner";
string losingMessage="Loser";

int die1 = 0;
int die2 = 0;
int die3 = 0;

int score=0;
int bonus=0;
int total=0;

//if any two dice you roll result in the same value, you get 2 bonus points for rolling doubles;

int[] rolled;
rolled = new int[3];



Random dice = new Random();

die1 = dice.Next(1, 7);
die2 = dice.Next(1, 7);
die3 = dice.Next(1, 7);

rolled[0] = die1;
rolled[1] = die2;
rolled[2] = die3;


total += (die1+die2+die3);
bool bonusPointsAwarded = ((die1 + die2 + die3) + bonus > 15);
bool bonusPointsNotAwarded = ((die1 + die2 + die3) + bonus < 15);


bool triples=(die1 == die2 && die2 == die3 && die1 == die3);
bool doubles=(die2 == die1) || (die2 == die3) || (die1 == die3);

/*
 *
 *
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}
 *
 *
 *
 *
 *
 * */


if (doubles && triples)
    {   
    bonus += 6;
    Console.WriteLine(@"
        You rolled triples!!
        ");

    }

if (doubles) 
    {
        bonus += 2;
 
      Console.WriteLine(@"
          You rolled doubles!!
          "); 


    }

if (bonusPointsAwarded)
    {
    Console.WriteLine($@"Bonus Awarded:
        {winningMessage}
        ");

    }

if (bonusPointsNotAwarded)
{
    Console.WriteLine($@"Bonus Not Awarded:

            {losingMessage}
            ");


}

else
{

    Console.WriteLine($@"{gameName}! ");
    score += (total + bonus);
    Console.WriteLine(score);
}

Console.WriteLine($@"Dice roll:

        [{die1}]  [{die2}]  [{die3}]
 
           ! {total} ! {bonus}
          ");    


Console.WriteLine($@"
        {rolled[0]}, {rolled[1]} ,{rolled[2]} 
        ");

//HelloWorld.Car.Method();
//HelloWorld.Driver.License();
//HelloWorld.Pedestrian.Speak();


int x=5;
Console.WriteLine($@"
       x==5 {x == 5},
       x>5 {x > 5},
       x<5 {x < 5},
       x=5 {x = 5},

        ");


Console.WriteLine(HelloWorld.Collection.Reverse(rolled));
