//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3, 7, 22, 2, 78] -> 76



int [] numbers = new int[5];
Console.Write("[");

int min = 100;
int max = 0;
for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(10, 98);
    Console.Write(" " + Method (i) + " ");
 }
Console.Write("]");



for (int i = 0; i < numbers.Length; i++)
 {
    if (numbers [i] < min )
    {
        min = numbers [i]; 
    }
    if (numbers [i] > max )
    {
        max = numbers [i]; 
    }


 }

int b = max - min;


int Method (int a)
{
    return numbers[a];
}

Console.Write(" -> " + b);