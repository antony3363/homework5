//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

int c = new Random().Next(4, 8);

int [] numbers = new int[c];
Console.Write("[");

int b = 0;

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(10, 98);
    Console.Write(" " + Method (i) + " ");
 }
Console.Write("]");

for (int i = 0; i < numbers.Length; i++)
 {
    if (i % 2 == 0)
    {
        b+=numbers [i];
    }
    
 }


int Method (int a)
{
    return numbers[a];
}

Console.Write(" -> " + b);







