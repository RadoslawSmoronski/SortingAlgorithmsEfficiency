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
                a[i] = rnd.Next(1, 10);
            }

            return a;
        }

        public int[] GenerateSorted(int size)
        {
            int[] a = GenerateRandom(size);
            Array.Sort(a);
            return a;
        }

        public int[] GenerateAlmostSorted(int size)
        {
            if(size < 10) throw new ArgumentOutOfRangeException("Array size must be bigger than 10.");

            int[] a = GenerateRandom(size);
            Array.Sort(a);

            int notSortedElementsAmount = (size / 10) - (size % 2 == 0 ? 1 : 0);

            Random rnd = new Random();

            for (int i = 0; i < notSortedElementsAmount; i++)
            {
                a[rnd.Next(0, size - 1)] = rnd.Next(0, 9);
            }

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
