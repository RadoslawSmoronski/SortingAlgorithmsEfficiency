using System;
using System.Collections.Generic;
namespace SortingAlgorithmsEfficiency
{
    public class ArrayGenerators
    {

        public int[] GenerateRandom(int size)
        {
            Random rnd = new Random();

            int[] a = new int[size];
            for (int i = 0; i < size; i++)
            {
                a[i] = rnd.Next(1, 10000);
            }

            return a;
        }

        public int[] GenerateSorted(int size)
        {
            int[] a = GenerateRandom(size);
            Array.Sort(a);
            return a;
        }

        public int[] GenerateReversed(int size)
        {
            int[] a = GenerateSorted(size);
            Array.Reverse(a);
            return a;
        }
    }
}
