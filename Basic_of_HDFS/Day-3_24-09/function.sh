#!usr/bin/bash


func_add () {
	local x=$1
	local y=$2
	result=$(( 100000000 * ( x + y ) ))

}

a=3;
b=4;

echo "The result is: "
func_add $a $b
echo $result
