using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdev3
{
    public class CustomerManeger
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Added customer");
            Console.WriteLine("customer Name : "+customer.Name);
        }

        public void ListCustomer(int id)
        {
            Console.WriteLine("Listed customer");
            Console.WriteLine("Listed customer id : "+id );
        }
        public void ListCustomers()
        {
            Console.WriteLine("Listed customers");
        }

        public void DeleteCustomer(int id)
        {
            Console.WriteLine("Deleted customer");
        }
    }
}
