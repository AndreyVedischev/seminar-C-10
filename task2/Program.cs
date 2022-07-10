using System;
using static System.Console;
Clear();

WriteLine("Введите длинну слова: ");
int n = int.Parse(ReadLine());
string alfavite= "аисе";

MnogoSlov(alfavite, n,"");

void MnogoSlov(string alf,int dlinna, string fix)
{
    if(dlinna ==0)
      WriteLine(fix);    
    else    
        foreach(char c in alf) MnogoSlov(alf, dlinna-1, fix+c);   

}
    