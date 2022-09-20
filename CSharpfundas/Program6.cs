using System;
using System.Collections;
using System.Collections.Generic;

ArrayList a = new ArrayList();
a.Add("hello");
a.Add("bye");
a.Add("Kome");
a.Add("apple");

Console.WriteLine(a[1]);

 foreach (string item in a)
{
    Console.WriteLine(item);
}

 Console.WriteLine(a.Contains("Kome"));
Console.WriteLine("After Sorting");

a.Sort();
foreach (string item in a)
{
    Console.WriteLine(item);
}