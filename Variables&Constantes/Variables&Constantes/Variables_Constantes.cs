// See https://aka.ms/new-console-template for more information

// Variables

string firstName = "John";
string lastName = "Doe";

Console.WriteLine("Name: "+ firstName + " " + lastName);

int numberOne = 5;
int numberTwo = 6;
Console.WriteLine(numberOne + numberTwo);

//int numberThree = "John"; Error

int numberThree;
numberThree = 7;
Console.WriteLine(numberOne + numberTwo + numberThree);

string anyName = "Frank";
anyName = "Gustavo";
Console.WriteLine(anyName);


//int a,
//    b = 10,
//    c = 20; Error


int a, b, c;

a = 1;
b = 2;
c = 3;

Console.WriteLine(a + b + c);

Console.WriteLine(Math.PI);

const string ConfigName = "This config will never change";

Console.WriteLine(ConfigName);

const int Months = 10;

// Months = 2; Error
Console.WriteLine(Months);
