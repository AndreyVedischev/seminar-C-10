using System;
using static System.Console;
Clear();

WriteLine(String.Join(", ", RezultNum(new int[] { 0, 1, 1, 1, 1, 0, 0, 0, 1 }, new int[] { 2, 3, 3, 1 })));

double[] RezultNum(int[] dat, int[] inf)
{
    double[] result = new double[inf.Length];
    int count = 0;
    for (int i = 0; i < inf.Length; i++)
    {
        for (int j = 0; j < inf[i]; j++)
        {
            result[i] += dat[count] * Math.Pow(2, inf[i]-j - 1);
            count++;
        }
    }
    return result;
}