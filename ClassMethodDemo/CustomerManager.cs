using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    public class CustomerManager
    {
         //Sisteme Müşteri Ekler
        public void Add(Customer customer)
        {
           
         Console.WriteLine("Müşteri {0, -10} {1,-10} Eklendi",customer.FirstName,customer.LastName);
         
        }
         
         //Sistemden Müşteri Siler
        public void Delete(Customer customer)
        {
            
            Console.WriteLine("Müşteri {0, -10} {1,-10} Silindi.",customer.FirstName,customer.LastName);
        }

        //Sistemdeki Müşterileri Listeler
        public void PrintCustomers(List<Customer> customers)
        {    
             
             foreach (var customer in customers)
             {
                 
                 Console.WriteLine("{0,-5} {1,-16} {2,-10} {3} ",
                         customer.Id, customer.FirstName,customer.LastName,
                         customer.CitizenshipNumber);
             }
        }
    }
}