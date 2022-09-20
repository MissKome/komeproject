using System;
using System.ComponentModel.DataAnnotations;

//
String[] a = { "hello", "bye", "Kome", "Mary" };
int[] b = { 1, 2, 3 };

string[] a1 = new string[4];
a1[0] = "hello";
a1[1] = "bye";

Console.WriteLine(a[1]);

for (int i = 0; i<a.Length; i++)
{
    Console.WriteLine(a[i]);
    if(a[i] == "Kome")
    {
        Console.WriteLine("Match found");
        break;
    }
}