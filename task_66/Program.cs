// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.WriteLine("Задайте первое число");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте второе число");
int numTwo = Convert.ToInt32(Console.ReadLine());

int SunNumber(int numberOne, int numberTwo)
{
    if (numberOne == numberTwo) return numberOne;

    else if (numberOne < numberTwo)
    {
        return numberOne + SunNumber(numberOne + 1, numberTwo);
    }
    else
    {
        return numberOne + SunNumber(numberOne - 1, numberTwo);
    }
}

int result = SunNumber(numOne, numTwo);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {numOne} до {numTwo} -> {result}");