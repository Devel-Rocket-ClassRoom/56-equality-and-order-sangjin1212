using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
int[] numbers = { 1, 2, 3, 4, 5 };
string[] words = { "apple", "banana", "cherry" };

Console.WriteLine($"numbers에 3 포함: {Contains(numbers, 3)}");
Console.WriteLine($"numbers에 10 포함: {Contains(numbers, 10)}");
Console.WriteLine($"words에 'banana' 포함: {Contains(words, "banana")}");
Console.WriteLine($"words에 'grape' 포함: {Contains(words, "grape")}");

static bool Contains<T>(T[] array, T target)
{
    EqualityComparer<T> comparer = EqualityComparer<T>.Default;
    foreach (T item in array)
    {
        if (comparer.Equals(item, target))
        {
            return true;
        }
    }
    return false;
}