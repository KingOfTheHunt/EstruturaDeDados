using System;
using EstruturaDeDados.Util;

namespace EstruturaDeDados.Tests
{
    static class ArrayTest
    {
        public static void Show()
        {
            Array<string> array = new Array<string>();

            array.Add("5");
            array.AddRange("1", "2", "3", "4", "6", "7", "8", "9");
            array.Insert(1, "18");
            array.Remove(4);
            array.Add("18");
            array.Add("11");

            Console.WriteLine("Vetor desorganizado:");
            Console.WriteLine(array);
            Console.WriteLine("Vetor organizado:");
            Console.WriteLine(array);
            Console.WriteLine($"Contém o número 18? {array.Contains("18")}");
            Console.WriteLine($"Contém o número 3? {array.Contains("3")}");
            Console.WriteLine($"Indíce da primeira aparição do 18: {array.IndexOf("18")}");
            Console.WriteLine($"Indíce da última aparição do 18: {array.LastIndexOf("18")}");
            array.RemoveAll("18");
            Console.WriteLine(array);
            array.Clear();
            Console.WriteLine(array);
        }
    }
}
