#!/bin/bash

# Shell
div=$1;
div1=$2;
div2=$3;

if [ `expr $div % $div1` -eq 0 -a `expr $div % $div2` -eq 0 ]
then
        echo true;
else
        echo false;
fi
