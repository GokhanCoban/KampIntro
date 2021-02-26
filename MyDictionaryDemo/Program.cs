using System;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>(7);
            myDictionary.Add("76232321626", "Engin Demiroğ");
            myDictionary.Add("12385469857", "Gökhan Çoban");
            myDictionary.Add("43598651421", "Ercan Uçar");
            myDictionary.Add("78933223655", "Akın Aras");
            






            int capacity = myDictionary.Capacity;
            int length = myDictionary.Length;
            Console.WriteLine("Kapasite : " + capacity);
            Console.WriteLine("Eleman Sayısı : " + length);


            string[] keys = myDictionary.Keys;
            string[] values = myDictionary.Values;

            Console.WriteLine("-------Keys-------");
            foreach (var item in keys)
            {
                if (item != null)
                {

                    Console.WriteLine("Key : " + item);
                }

            }

            Console.WriteLine("-------Values-------");
            foreach (var item in values)
            {
                if (item != null)
                {

                    Console.WriteLine("Value : " + item);
                }

            }

            //Çıktı Şöyle olacaktır.
            /* 

            Kapasite: 7
            Eleman Sayısı : 4
            --------Keys--------
            Key: 76232321626
            Key: 12385469857
            Key: 43598651421
            Key: 78933223655
            --------Values--------
            Value: Engin Demiroğ
            Value: Gökhan Çoban
            Value: Ercan Uçar
            Value: Akın Aras 

            */

        }
    }
}
