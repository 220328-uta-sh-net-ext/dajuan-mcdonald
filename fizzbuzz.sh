#!/usr/bin/env bash

echo $(date)

echo "oooooooooooooooooooooooooooooo."
echo "88888888888888Y888888888b88888."
echo "88888888888_888888888888888888."
echo "8000000000|." 
echo "oooooooooo|"
echo "oooooooooo|"
echo "oooooooooo|Looooooooo}"
echo "oooooooooooooooooooo}}"
echo "oppppppppppppppppppp}}"
echo "oooooooooo|"
echo "8888888888|."
echo "oo88888Y88|"
echo "8888888888|"

echo "oooooooooo| "
echo "          |"
echo "__________|"

echo "                                              X."





















echo " This program takes input of integer and outputs either string or integer: "
echo " "
echo " The range of 1 to your input determins if the output will be either: "
echo " "
echo " Fizz, Buzz, or FizzBuzz"
echo " "
echo " If Fizz, the number is divisible by 3"
echo " "
echo " If Buzz, the number is divisible by 5"
echo " "
echo " if FizzBuzz, the number is divisible by 3 and 5"
echo " "
echo " otherwise the output will just be ... nothing!"




fizzbuzz() {

Fizz=3
Buzz=5
FizzBuzz=15

read -p "Enter a number between 1 and 100: " target "\n"

for ((i=1; i < $target+1; i++));
  
    do 
        if (( $i % $FizzBuzz == 0  ));
    then 
        echo "FizzBuzz";

        elif (( $i % $Fizz == 0 ));
    then
        echo "Fizz";

        elif (( $i % $Buzz == 0 ));
    then
        echo "Buzz";

    else

        echo "$i";
        fi;
done;
}

fizzbuzz
