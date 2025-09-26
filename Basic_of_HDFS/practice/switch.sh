#!/usr/bin/bash

echo "Enter choice:"
read num

case $num in
	1) echo "You chose 1";;
	2) echo "you chose 2";;
	*) echo "invalid";;
esac

