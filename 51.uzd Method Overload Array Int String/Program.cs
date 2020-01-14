using System;

namespace _51.uzd_Method_Overload_Array_Int_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intValues = { 1, 22, 333, 4444, 55555 };
            PrintArrayValues(intValues);

            string[] stringValues = { "A", "BB", "CCC", "DDDD", "EEEEE" };
            PrintArrayValues(stringValues);
        }

        static void PrintArrayValues(int[] values)
        {
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
        }

        static void PrintArrayValues(string[] values)
        {
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}

// Izveidot metodi PrintArrayValues, kura kā parametru saņem int[] un izdrukā visas tā vērtības. 
// Izmantojot metožu overload funkciju definēt metodi PrintArrayValues, kura kā parametru saņem string[] 
// un var izdrukāt string[] visas vērtības.