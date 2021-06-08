using System;

namespace KampOdev3
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            var customerManeger = new CustomerManeger();

            var customer1 = new Customer
            {
                Id = 1,
                Name = "Aziz",
                SurName = "Korkmaz",
                Email = "aziz.com",
                Age = 30
            };

            customerManeger.AddCustomer(customer1);
            customerManeger.ListCustomer(customer1.Id);

        }
    }
}
