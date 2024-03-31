// See https://aka.ms/new-console-template for more information


// arimeticos

using Operaciones;
using System.Xml.Serialization;

int a = 5;
int b = 5;

Console.WriteLine(a + b);
Console.WriteLine(a * b);

int c = a + b;

Console.WriteLine(c / b);

Console.WriteLine( a + b * c);
Console.WriteLine((a + b) * c);

// Comparacion

Console.WriteLine(b > c);
Console.WriteLine(b == c);
Console.WriteLine(b < c);
Console.WriteLine(b < c && a > c);
Console.WriteLine(b < c || a > c);
Console.WriteLine(!(b < c || a > c));
Console.WriteLine(b != c);

Comentarios comentarios = new Comentarios();
comentarios.hola("Hellow World");
