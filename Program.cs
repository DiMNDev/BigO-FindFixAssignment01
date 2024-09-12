// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 3, 8, 1, 9, 2, 7, 4, 6 };

        Console.WriteLine("Sum of numbers: " + Sum(numbers));
        Console.WriteLine("Maximum value: " + FindMax(numbers));
        Console.WriteLine("Find prime numbers: " + string.Join(", ", FindPrimes(numbers)));
        Console.WriteLine("Find duplicates: " + string.Join(", ", FindDuplicates(numbers)));
        Console.WriteLine("Sorting numbers...");
        List<int> sortedNumbers = SortNumbers(numbers);
        Console.WriteLine("Sorted numbers: " + string.Join(", ", sortedNumbers));
    }

    static int Sum(List<int> numbers)
    {
        int sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    static int FindMax(List<int> numbers)
    {
        int max = int.MinValue;
        foreach (var number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        return max;
    }

    static List<int> FindPrimes(List<int> numbers)
    {
        List<int> primes = new List<int>();
        foreach (var number in numbers)
        {
            if (IsPrime(number))
            {
                primes.Add(number);
            }
        }
        return primes;
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    static List<int> FindDuplicates(List<int> numbers)
    {
        HashSet<int> seen = new HashSet<int>();
        List<int> duplicates = new List<int>();

        foreach (var number in numbers)
        {
            if (!seen.Add(number))
            {
                duplicates.Add(number);
            }
        }

        return duplicates;
    }

    static List<int> SortNumbers(List<int> numbers)
    {
        List<int> sorted = new List<int>(numbers);
        bool swapped;
        do
        {
            swapped = false;
            for (int i = 0; i < sorted.Count - 1; i++)
            {
                if (sorted[i] > sorted[i + 1])
                {
                    int temp = sorted[i];
                    sorted[i] = sorted[i + 1];
                    sorted[i + 1] = temp;
                    swapped = true;
                }
            }
        } while (swapped);

        return sorted;
    }
}
