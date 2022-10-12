using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Name","Balaji");
            ht.Add("age","23");
            ht.Add("salary", "27000");
            ht.Add("account", "TSG");
            DictionaryEntry[] myarr = new DictionaryEntry[ht.Count];
            ht.CopyTo(myarr, 0);
            for (int i = 0; i < myarr.Length; i++)
                Console.WriteLine(myarr[i].Key + " --> "
                                  + myarr[i].Value);

        }
    }
}
