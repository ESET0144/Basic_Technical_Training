#!usr/bin/bash



my_array=("abc" "bcd" "cde")

echo "The first element is: ${my_array[0]}"

echo "The array is: ${my_array[@]}"

echo "the length of the array is: ${#my_array[@]}"

my_array_2=("def" "efg")

two=(${my_array[@]} ${my_array_2[@]})

echo "${two[@]}"
