using System;
using System.Collections.Generic;

namespace MyDictionaryDemo
{
    public class MyDictionary<TKey,TValue>
    {
       private  TKey[] keys=null;
       private TValue[] values=null;
       private  int _capacity=0;
       private const int _defaultCapacity=5;
       private int _length=0;
      
      //Varsayılan olarak bu nesnenin kapasitesi 5 olacak şekilde başlar.
      public MyDictionary()
      {
          _capacity=_defaultCapacity;
          keys=new TKey[_capacity];
          values=new TValue[_capacity];

      }

       //Parametre olarak kapasite alır.
       public MyDictionary(int capacity)
        {
            _capacity=capacity;
            keys=new TKey[_capacity];
            values=new TValue[_capacity];

        }
    
       //Bu listeye anahtar ve değer biçiminde bir eleman ekler.
        public void Add(TKey key,TValue value)
        {

             keys.SetValue(key,_length);
             values.SetValue(value,_length);
            _length+=1;

            if (_capacity==_length)
            {
                int _newCapacity= _capacity*=2;
               
               TKey[] _tempKeys=keys;
               TValue[] _tempValues=values;

               keys=new TKey[_newCapacity];
               values=new TValue[_newCapacity];

               for (int i = 0; i < _length; i++)
               {
                   keys[i]=_tempKeys[i];
                   values[i]=_tempValues[i];
               }
                
            }
        }
       
       //Bu listeye eklenen tüm "anahtarları" döndürür.
        public TKey[] Keys {
            
             get {
                 
                  TKey[] allKeys=new TKey[_length];
                 for (int i = 0; i <= _length-1; i++)
                 {
                     allKeys[i]=keys[i];
                 }
                 
                 return allKeys;
                 }
        
         }

       //Bu listeye eklenen tüm "değerleri" döndürür.
         public TValue[] Values 
         {
              get
              {
                  TValue[]  allValues=new TValue[_length];

                  for (int i = 0; i <_length; i++)
                  {
                      allValues[i]=values[i];
                  }
                  
                  return allValues;
              }
         }
       
       //Bu listenin kapasitesini döndürür 
        public  int  Capacity { get { return _capacity; }}

       //Bu listenin eleman sayısını döndürür.
        public int Length { get {return _length;} }


    }
}