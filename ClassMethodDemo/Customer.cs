using System;

namespace ClassMethodDemo
{
    public class Customer
    {
         public int Id { get; set; }
        
        //Müşteri Adı.
        public string FirstName { get; set; }
       
        //Müşteri Soyadı.
        public string LastName { get; set; }
       
        //Müşteri Vatandaşlık Numarası (T.C. NO)
        public string CitizenshipNumber { get; set; }

    }
}