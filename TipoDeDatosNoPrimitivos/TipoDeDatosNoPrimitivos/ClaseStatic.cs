﻿//using TipoDeDatosNoPrimitivos;
using TipoDeDatosNoPrimitivos;

namespace MainNameSpace
{
    internal class ClaseStatic
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(Calculations.GetSum(2, 5));

            //Customer customer = new Customer();
            //Console.WriteLine(customer.GetPrettyFormat("John","Wick"));
            //Console.WriteLine(customer.GetAddreess());
            Console.WriteLine(Customer.GetPrettyFormat("John", "Wick"));
            Console.WriteLine(Customer.GetAddreess());

            NoStatic noStatic = new NoStatic();
            Console.WriteLine(noStatic.Hello2());
            //Console.WriteLine(noStatic.Hello());
            Console.WriteLine(NoStatic.Hello());

            Customer_2 customer_2 = new Customer_2();
            customer_2.Gender = "M";
            Console.WriteLine(customer_2.GetPrettyFormat("Gustavo", "Chao"));
            customer_2.Alias = "Hola";
            Console.WriteLine(customer_2.IsFrequentCustomer());

            Console.WriteLine("");
            Categories categories = Categories.Food;
            Console.WriteLine(categories);

            int catNumber = (int)Categories.Food;
            Console.WriteLine(catNumber);

            int catNumber2 = (int)Categories_2.Food;
            Console.WriteLine(catNumber2);

        }
    }

    // Static no hace falta instanciar la clase
    // Una clase estatica solo puede contener métodos estáticos
    // Una clase no estatica puede contener metodos estaticos, aunque no pueden ser accedidos desde los objetos
    // Una clase no estatica que contine metodos estaticos, puede ser instanciada como cualquier otra clase
    // los miembros de una clase statica deben ser static


    // Funciones locales -> Funciones dentro de las funciones

    public class NoStatic
    {
        public static string Hello()
        {
            return "Hola";
        }

        public string Hello2()
        {
            return Hello();
        }
    }

    public static class Calculations
    {
        public static int GetSum(int n1, int n2)
        {
            return n1 + n2;
        }
    }

    public static class Customer
    {        
        public static string Id { get; set; }
        public static string Street { get; set; }
        public static string Number { get; set; }

        public static string GetPrettyFormat(string firstName,  string lastName)
        {
            return lastName + ", " + firstName;
        }

        public static string GetAddreess()
        {
            return Street + " " + Id;
        }
    }

    partial class Customer_2
    {
        public string Id { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }

        public string Gender { get; set; }

        public string GetPrettyFormat(string firstName, string lastName)
        {
            string GetLastName()
            {
                if (Gender == "M")
                    return "Mr " + lastName;
                else
                    return "Miss " + lastName;
            }

            //return lastName + ", " + firstName;
            return GetLastName() + ", " + firstName;
        }

        public string GetAddreess()
        {
            return Street + " " + Id;
        }
    }

    partial class Customer_2
    {
        public string email { get; set; }
    }
}