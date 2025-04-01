using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using SortingAlgorithmsEfficiency;
using System;

namespace SortingBenchmarks
{
    [MemoryDiagnoser]
    public class SortingBenchmark
    {
        private SortingAlgorithms sorter = new SortingAlgorithms();
        private ArrayGenerators arrayGenerators = new ArrayGenerators();
        private int[] array;

        [Params(10, 100, 1000)]
        public int N;

        [Params("Random", "Sorted", "AlmostSorted", "Reversed")]
        public string ArrayType = String.Empty;

        [GlobalSetup]
        public void Setup()
        {
            switch (ArrayType)
            {
                case "Random":
                    array = arrayGenerators.GenerateRandom(N);
                    break;
                case "Sorted":
                    array = arrayGenerators.GenerateSorted(N);
                    break;
                case "AlmostSorted":
                    array = arrayGenerators.GenerateAlmostSorted(N);
                    break;
                case "Reversed":
                    array = arrayGenerators.GenerateReversed(N);
                    break;
                default:
                    throw new ArgumentException($"Unknown ArrayType: {ArrayType}");
            }
        }

        // InsertionSort
        [Benchmark]
        public int[] InsertionSort() => sorter.InsertionSort((int[])array.Clone());

        // MergeSort
        [Benchmark]
        public int[] MergeSort() => sorter.MergeSort((int[])array.Clone(), 0, array.Length - 1);

        // QuickSortClassical 
        [Benchmark]
        public int[] QuickSort() => sorter.QuickSort((int[])array.Clone(), 0, array.Length - 1);


        // Array.QuickSort
        [Benchmark]

        public int[] ArrayQuickSort() => sorter.StandardArrayQuickSort((int[])array.Clone());
    }
}
