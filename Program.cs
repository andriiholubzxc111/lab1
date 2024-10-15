using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList computerCompanies = new SortedList();
            computerCompanies.Add("1", "Lenovo");
            computerCompanies.Add("2", "Apple");
            computerCompanies.Add("3", "Samsung");
            computerCompanies.Add("4", "Gigabyte");
            computerCompanies.Add("5", "MSI");
            computerCompanies.Add("6", "Kingston");
            computerCompanies.Add("7", "AMD");
            computerCompanies.Add("8", "Intel");

            Console.WriteLine("Список в прямому порядку:");
            foreach (DictionaryEntry entry in computerCompanies)
            {
                Console.WriteLine("{0}:{1}", entry.Key, entry.Value);
            }

            Console.WriteLine("Список в зворотньому порядку:");
            foreach (DictionaryEntry entry in computerCompanies.Cast<DictionaryEntry>().Reverse())
            {
                Console.WriteLine("{0}:{1}", entry.Key, entry.Value);
            }

            computerCompanies.Clear();
        }
    }
}
