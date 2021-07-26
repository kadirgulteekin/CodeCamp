using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Kitap = new Dictionary<int, string>();
            Kitap.Add(134, "Akıllı Yatırımcı");
            Console.WriteLine(Kitap.Count);


            MyDictionary<int, string> Kitap2 = new MyDictionary<int, string>();
            Kitap2.Add(125, "Yalın Startup");
            Kitap2.Add(125, "Çok Yönlü");
            Kitap2.Add(125, "Dahilerin Tuhaf Dünyası");
            Console.WriteLine(Kitap2.Count);



            Console.ReadLine();
        }
    }
    class MyDictionary<TKey, TValue>
    {
        TKey[] key;

        TValue[] value;


        public MyDictionary()
        {
            key = new TKey[0];
            value = new TValue[0];
        }

        public void Add(TKey key1, TValue value1)
        {
            TKey[] tempKey = key;
            TValue[] tempValue = value;

            key = new TKey[key.Length + 1];
            value = new TValue[value.Length + 1];


            for (int i = 0; i < tempKey.Length; i++)
            {
                key[i] = tempKey[i];
            }
            for (int i = 0; i < tempValue.Length; i++)
            {
                value[i] = tempValue[i];
            }

            key[key.Length - 1] = key1;
            value[value.Length - 1] = value1;

        }

        public int Count
        {
            get { return key.Length; }
        }

        public TKey[] key1
        {
            get { return key; }
        }
        public TValue[] value1
        {
            get { return value; }
        }


    }
}
