using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Customer instance
            Customer customer1=new Customer();
            customer1.Id=1;
            customer1.FirstName="Gökhan";
            customer1.LastName="Çoban";
            customer1.CitizenshipNumber="425789562365";
            
            // 2. Customer instance
            Customer customer2=new Customer();
            customer2.Id=2;
            customer2.FirstName="Ercan";
            customer2.LastName="Uçar";
            customer2.CitizenshipNumber="879513654321";

            Customer customer3=new Customer();
            customer3.Id=3;
            customer3.FirstName="Süleyman";
            customer3.LastName="Çakır";
            customer3.CitizenshipNumber="565656565560";
            
            Customer customer4=new Customer();
            customer4.Id=4;
            customer4.FirstName="Polat";
            customer4.LastName="Alemdar";
            customer4.CitizenshipNumber="595956336890";


             
            //CustomerManager instance
            CustomerManager manager=new CustomerManager();
            
            Console.WriteLine("\nMüşteri Ekleme Sayfası");
            manager.Add(customer1);
            manager.Add(customer2);
            manager.Add(customer3);
            manager.Add(customer4);
            
            //Console.WriteLine("");
            Console.WriteLine("\nMüşteri Silme Sayfası");
            manager.Delete(customer3);
            manager.Delete(customer4);
             
            
             //Müşteri Listesi
             List<Customer> customers=new List<Customer>
             {
                 customer1,
                 customer2,
                 customer3,
                 customer4
             };

            Console.WriteLine("\n Müşteri Görüntüleme Sayfası \n");
            Console.WriteLine("{0,-7} {1,-13} {2,-13} {3}","ID","AD","Soyad","TC NO");
            Console.WriteLine();
            manager.PrintCustomers(customers);
            Console.WriteLine();

        }
    }
}
