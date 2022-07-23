// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

Console.WriteLine("Задайте первое число");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте второе число");
int numTwo = Convert.ToInt32(Console.ReadLine());

int Akkerman (int numberOne, int numberTwo)
{
    if (numberOne == 0) return numberTwo +1;
    else if ((null != 0) && (numberTwo == 0)) return Akkerman(numberOne-1,1);
    else return Akkerman(numberOne-1, Akkerman(numberOne,numberTwo-1));
}

int result = Akkerman(numOne,numTwo);
Console.WriteLine($"Функция Аккермана ({numOne},{numTwo}) -> {result}");
