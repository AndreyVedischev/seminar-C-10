using System;
using static System.Console;
Clear();

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };

if (GetSum(info) != data.Length)
{
    WriteLine("Неверная длинна данных.");
    return;
}
WriteLine(String.Join(" ", RezultNum(data, info)));



int[] RezultNum(int[] datArr, int[] infArr)
{
    int[] result = new int[infArr.Length];
    string dat = String.Join("", datArr);
    for (int i = 0; i < result.Length; i++)
    {
        string subData = dat.Substring(0, infArr[i]);
        result[i] = Convert.ToInt32(subData, 2);
        dat = dat.Remove(0, infArr[i]);
    }
    return result;
}

int GetSum(int[] array)
{
    int sum = 0;
    foreach (int item in array)
    {
        sum += item;
    }
    return sum;
}