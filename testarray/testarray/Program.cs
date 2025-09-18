using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testarray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[3] { "абв", "нет", "мит" };
            array[1] = "да";
            Console.WriteLine($"Элементы массива:{array[0]},{array[1]},{array[2]}");
            string[] array2 = new string[3];
            int[] array3 = new int[10000];
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = (i+1)*2;
            }
            for (int i = 0; i < array3.Length/2; i++)
            {
                int temp = array3[i];
                array3[i] = array3[array3.Length - 1 - i];
                array3[array3.Length - 1 - i] = temp;
            }
            Console.Write("[");
            for (int i = 0; i < array3.Length-1; i++)
            {
                Console.Write($"{array3[i]}, ");
            }
            Console.Write($"{array3[array3.Length-1]}]");
        }
    }
}
