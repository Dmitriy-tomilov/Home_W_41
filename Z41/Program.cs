// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.WriteLine("введите сколько будет чисел");
int num =Convert.ToInt32(Console.ReadLine());

int i =1;
int Count =0;

while (i<=num)
{
    Console.WriteLine("введите число");
    int num1 = Convert.ToInt32(Console.ReadLine());
    i++;
    if (num1>0)
    {
        Count++;
    }
}
Console.WriteLine("количество чисел больше нуля =" +Count);

