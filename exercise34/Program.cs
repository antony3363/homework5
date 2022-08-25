//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int [] numbers = new int[4];
Console.Write("[");

int b = 0;

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(100, 998);
    Console.Write(" " + Method (i) + " ");
 }
Console.Write("]");

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] %=2;
    if (numbers [i] == 0)
    {
        b+=1;
    }
 }


int Method (int a)
{
    return numbers[a];
}

Console.Write(" -> " + b);