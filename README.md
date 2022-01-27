# BrianFuck

This is a compiler for my "over the weekend" programing language. It was based on programing language called brainfuck. 

## Programing

Imagine this programing language as 2 30000 cells long arrays filled with zeros. You also have 2 pointers that start at 0 for each of them. For simplicity lets call them fuck and brian (because i call them that in the code). 
Fuck can get user input, while brian can read and write from fuck. 
You have 8 commands as fuck:
- + Incrise value of a cell
- - Decrease value of a cell
- \> Move fuck pointer right
- < Move fuck pointer left
- \[ Need for ']'
- ] If value of cell isn't 0, go to last '\['
- . Write value in a cell in ascii
- , Read value from input

As brian you also have 8 commands:
- k Incrise value of a cell
- j Decrease value of a cell
- h Move brian pointer left
- l Move brian pointer right
- : Copy value from brian to fuck
- ; Copy value from fuck to brian

There is also ? command that writes into fuck cell random number from 1 to value of brian. 
All other characters are ignored. 

## Compiling 

Alfter you compile this program just run it and write path to your braianfuck script. 
