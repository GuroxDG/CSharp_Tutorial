using MySecondNameSpace;
using System.Xml.Schema;

internal class Program
{
    private static void Main(string[] args)
    {
        // public  -> Accesible desde cualquier lugar
        // protected  -> Acceso desde la misma clase o desde clases heredadas de esa clase
        // internal -> Accesible dentro del mismo proyecto
        // protected internal -> Accesible desde otro proyectos si las clases heredan de esta clase
        // private -> accesible solo desde es clase

        // Metodos
        //  <visibility> <return type> <name> (<parameters>)
        //  {
        //      <code>
        //  }

        // Using <Nombre del namespace>

        //
        //Usar alias
        //
        // using System.Web.Script.Serialization;
        // var js = new System.Web.Script.Serialization.JavaScriptSerializer();
        // 
        // using JS = System.Web.Script.Serialization;
        //

        Customer customer = new Customer();
        customer.FirstName = "Gustavo";

        Customer customer2 = new Customer("Ibarra");

        Customer customer3 = new Customer("Gustavo", "Ibarra");

        Console.WriteLine(customer.FirstName);
        Console.WriteLine(customer2.LastName);
        Console.WriteLine(customer3.FirstName + " " + customer3.LastName);
        Console.WriteLine(customer3.GetFullName());

        MySecondNameSpace.Product productor = new Product();
        Console.WriteLine(productor.GetCustomer());
        
    }
}

class Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }

    //Constructores
    public Customer() { } 
    public Customer(string lastname)
    {
        LastName = lastname;
    }
    public Customer(string firstname, string lastname)
    {
        FirstName = firstname;
        LastName = lastname;    
    }

    public string GetFullName() 
    { 
        return LastName + ", " + FirstName;
    }
}

namespace MySecondNameSpace
{
    class Product
    {
        public string GetCustomer() 
        {
            Customer customer = new Customer("Gustav", "Piandoy");
            return customer.GetFullName();
        }
    }
}