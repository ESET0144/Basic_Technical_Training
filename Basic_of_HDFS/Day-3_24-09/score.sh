#!usr/bin/bash


echo "what is your score:"
read score

if [ $score -ge 75 ]; then
       echo "your bucket is 4"
elif [ $score -ge 50 ]; then
 	echo "your bucket is 3"
elif [ $score -ge 25 ]; then
	echo "your bucket is 2"
else
	echo "your bucket is 1"
fi	
