using System;
using System.Collections;

namespace DictionaryCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();

            hashtable["0"] = "Zero";
            hashtable["1"] = "One";
            hashtable["2"] = "Two";
            hashtable["3"] = "Three";
            hashtable["4"] = "Four";
            hashtable["5"] = "Five";
            hashtable["6"] = "Six";
            hashtable["7"] = "Seven";
            hashtable["8"] = "Eight";
            hashtable["9"] = "Nine";

            string ourNumber = "888-555-1212";

            foreach (char c in ourNumber)
            {
                string digit = c.ToString();
                if (hashtable.ContainsKey(digit))
                {
                    Console.WriteLine(hashtable[digit]);
                }
            }
        }
    }
}
