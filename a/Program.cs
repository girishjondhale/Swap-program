// See https://aka.ms/new-console-template for more information

int a = 10,b= 20,temp;
temp = a;
a = b;
b= temp;

Console.WriteLine("values after swap");
Console.WriteLine("a=" + a);
Console.WriteLine("b=" + b);