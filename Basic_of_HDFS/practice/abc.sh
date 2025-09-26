#!/usr/bin/bash


echo "How many terms of fibonacci you want?"
read num
a=0
b=1
echo $a

for ((i=1; i<=$num; i++))
do
	echo $a
	
	fn=$((a+b))
	a=$b
	b=$fn
done

