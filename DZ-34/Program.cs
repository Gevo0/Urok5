/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/



Console.WriteLine("Введите размер массива ");

int size = int.Parse(Console.ReadLine());

int[] num = new int[size];

Random rand = new Random();

for (int i = 0; i < num.Length; i++)
{
    num[i] = rand.Next(100, 1000);
    Console.WriteLine(num[i]);
}

int Count = 0;
foreach (int number in num)
{
if (number % 2 == 0)

{
 Count ++; 
}
    
}
Console.WriteLine("Количество четных чисел в массиве: " + Count);
