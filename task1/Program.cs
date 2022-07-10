using System;
using static System.Console;
Clear();

WriteLine("Введите первое число ряда: ");
int n = int.Parse(ReadLine());
WriteLine("Введите второе число ряда: ");
int k = int.Parse(ReadLine());

WriteLine("Введите длинну ряда: ");
int stop = int.Parse(ReadLine());
PosledSum(n,k,stop);

void PosledSum(int number1, int number2, int i)
{
    if(i == 0)
    {
        return;
    }
    Write($"{number1}, ");
    PosledSum(number2,number1+number2,i-1);    
}