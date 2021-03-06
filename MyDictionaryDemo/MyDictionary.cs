using System;
using System.Collections.Generic;

namespace MyDictionaryDemo
{
    public class MyDictionary<TKey, TValue>
    {
        private TKey[] _keys = null;
        private TValue[] _values = null;
        private int _capacity = 0;
        private int _defaultCapacity = 5;
        private int _length = 0;

        //Varsayılan olarak bu nesnenin kapasitesi 5 olacak şekilde başlar.
        public MyDictionary()
        {
            _capacity = _defaultCapacity;
            _keys = new TKey[_capacity];
            _values = new TValue[_capacity];

        }

        //Parametre olarak kapasite alır.
        public MyDictionary(int capacity)
        {
            _capacity = capacity;
            _keys = new TKey[_capacity];
            _values = new TValue[_capacity];

        }

        //Bu listeye anahtar ve değer biçiminde bir eleman ekler.
        //Eğer kapasite eleman sayısına eşitse kapasiteyi 2 katına çıkarır.
        public void Add(TKey key, TValue value)
        {

            _keys.SetValue(key, _length);
            _values.SetValue(value, _length);
            _length += 1;

            if (_capacity == _length)
            {
                int _newCapacity = _capacity *= 2;

                TKey[] _tempKeys = _keys;
                TValue[] _tempValues = _values;

                _keys = new TKey[_newCapacity];
                _values = new TValue[_newCapacity];

                for (int i = 0; i < _length; i++)
                {
                    _keys[i] = _tempKeys[i];
                    _values[i] = _tempValues[i];
                }

            }
        }

        //Bu listeye eklenen tüm "anahtarları" döndürür.
        public TKey[] Keys
        {

            get
            {

                //Bu eski kod parçası
                //Aslında bir altta sadece tek satır kod yetiyordu.

                /* TKey[] allKeys=new TKey[_length];
               for (int i = 0; i <= _length-1; i++)
               {
                   allKeys[i]=keys[i];
               }

               return allKeys; */

                return _keys;

            }

        }

        //Bu listeye eklenen tüm "değerleri" döndürür.
        public TValue[] Values
        {
            get
            {
                //Bu eski kod parçası
                //Aslında bir altta sadece tek satır kod yetiyordu.

                /* TValue[]  allValues=new TValue[_length];

                for (int i = 0; i <_length; i++)
                {
                    allValues[i]=values[i];
                }

                return allValues; */

                return _values;
            }
        }

        //Bu listenin kapasitesini döndürür 
        public int Capacity { get { return _capacity; } }

        //Bu listenin eleman sayısını döndürür.
        public int Length { get { return _length; } }


    }
}