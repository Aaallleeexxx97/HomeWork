using System;

class Program
{
    static       void Main() {
    string a = "12821";
    int b = 0;
    int c = a.Length;
    for(int i = a.Length /2;i>0;i--)
    {
        if(a[b] !=a[c-1]) 
        {
            Console.WriteLine("Это не полеандром");
            break;
        }
        else if(a[b] ==a[c-1] && i == 1)
        {
            Console.WriteLine("Это полеандром");
            break;
        }
        b++;
        c--;
    }
    }
    }