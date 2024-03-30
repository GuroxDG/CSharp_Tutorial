// See https://aka.ms/new-console-template for more information

byte numF = 100;
int secondNumber = numF;
Console.WriteLine(secondNumber);

int numF1 = 100;
// byte secondNumber1 = numF1; Error no se puede convertir implicitamente
int secondNumber1 = numF1;
Console.WriteLine(secondNumber1);

int numF2 = 100;
// Conversion explicita siempre que no se exceda la capacidad del dato
byte secondNumber2 = (byte)numF2;
Console.WriteLine(secondNumber2);

int numF3 = 1000;
// Conversion explicita excediendo la capacidad del dato
// Error en el cambio
byte secondNumber3 = (byte)numF3;
Console.WriteLine(secondNumber3);

string txtNumber = "1234";

int num =  Int32.Parse(txtNumber);
Console.WriteLine(num);

int num2 = int.Parse(txtNumber);
Console.WriteLine(num2);

try
{
    string txtNumber2 = "1234.2";

    int num3 = int.Parse(txtNumber2);
    Console.WriteLine(num3);
}
catch (Exception)
{
    Console.WriteLine("Something went wrong"); 
}

string txtNumber3 = "1234";
int number2;
bool ok = int.TryParse(txtNumber3, out number2);
Console.WriteLine(ok);

string txtNumber4 = "mark";
int number3;
bool ok1 = int.TryParse(txtNumber4, out number3);
Console.WriteLine(ok1);

string txtNumber5 = "1234";
int number4 = Convert.ToInt32(txtNumber5);
Console.WriteLine(number4);

string txtNumber6 = "true";
bool ok4 = Convert.ToBoolean(txtNumber6);
Console.WriteLine(ok4);
