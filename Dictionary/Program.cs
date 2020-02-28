using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> newDictionary = new Dictionary<string,int>();
            newDictionary.Add("BA", 2);
            newDictionary.Add("1", 2);
            newDictionary.Add("CA", 2);
            //newDictionary.Add("1", 2);
            //newDictionary.Add("A.A", 2);
            //newDictionary.Add("A.A.B", 2);
            //newDictionary.Add("A.A.A", 2);
            //newDictionary.Add("-1", 2);
            //newDictionary.Add("@", 2);
            //newDictionary.Add("{", 2);
            //newDictionary.Add("{}", 2);
            //newDictionary.Add("-C", 2);


            List<string> newList = new List<string>();
            newList.Add("C");

            newList.Add("A"); 
            newList.Add("E");
            newList.Add("B");
            newList.Add("D");

            var listOrdered = newList.OrderBy(p=>p).ToList();
            foreach(var item in listOrdered)
            {
                Console.WriteLine(item);
            }


            foreach (var item in newList){
            try{
            //int itemValue;
            var added = newDictionary.TryAdd(item, 1);
            }
            catch (Exception e){
            }
            }

            var newDictionary2 = newDictionary.OrderBy(p=>p.Key).GroupBy(p=>p.Value).ToList();

            foreach (var lstGroup in newDictionary2)
            {
                foreach (var item in lstGroup)
                {
                    //Console.WriteLine(item);
                }
            }

            //Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}

