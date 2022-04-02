#!/usr/bin/env bash

array_1=(1 2 3 4 5)
array_2=("one" "two" "three" "four" "five")

for i in $array_1
do
    echo $array_1[$i]
done

for i in $array_2
do
    echo $array_2[$i]
done


# echo $array_1
# echo $array_2

