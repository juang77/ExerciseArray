using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 12345;
            int[] intList = GetIntArray(result);


            Console.WriteLine("Aqui empieza el Programa");
            int[] ArrayTest = {-1,-3 };
            Console.WriteLine("El Resultado es: " + Solution(ArrayTest).ToString());
            Console.ReadLine();
        }

        public static int[] GetIntArray(int num)
        {
            List<int> listOfInts = new List<int>();
            while (num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }
            listOfInts.Reverse();
            return listOfInts.ToArray();
        }

        public static int Solution(int[] A)
        {
            int max = 1;
            Comparison<int> comparador = new Comparison<int>((numero1, numero2) => numero1.CompareTo(numero2));
            Array.Sort<int>(A, comparador);
            for (int i = 0; i < A.Length; i++)
            {
                if (max == A[i]) {
                    max = A[i] + 1;
                }
            }
            
            return max;
        }
    }
}
