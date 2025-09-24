#!usr/bin/bash

echo "what's your name?"
read name

echo "what's your age?"
read age

if [ $age -ge 18 ]; then
	echo "Hi $name, you can vote."

else
	echo "Hi $name, You can't vote."
fi

