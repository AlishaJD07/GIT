using System;

namespace HandsOnClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //object creation
            Customer customer = new Customer();
            customer.CustomerId = 12345;
            customer.CustomerName="Rohan";
            customer.City = "Chennai";
            Console.WriteLine("Customer Id:" + customer.CustomerId);
            Console.WriteLine("Customer Name:" + customer.CustomerName);
            Console.WriteLine("Customer city:" + customer.City);
            Customer customer1 = new Customer();
            Console.WriteLine("Customer Id:" + customer1.CustomerId);
            Console.WriteLine("Customer Name:" + customer1.CustomerName);
            Console.WriteLine("Customer city:" + customer1.City);



        }
    }
}
