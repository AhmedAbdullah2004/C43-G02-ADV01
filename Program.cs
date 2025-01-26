using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment
{
    // 1
    //public class Range<T> where T : IComparable<T>
    //{
    //    public T Minimum { get; }
    //    public T Maximum { get; }

    //    #region Constructor
    //    public Range(T minimum, T maximum)
    //    {
    //        if (minimum.CompareTo(maximum) > 0)
    //        {
    //            throw new ArgumentException("Minimum value cannot be greater than the maximum value.");
    //        }

    //        Minimum = minimum;
    //        Maximum = maximum;
    //    }
    //    #endregion

    //    public bool IsInRange(T value)
    //    {
    //        return value.CompareTo(Minimum) >= 0 && value.CompareTo(Maximum) <= 0;
    //    }

    //    public dynamic Length()
    //    {
    //        if (typeof(T) == typeof(int) || typeof(T) == typeof(double) || typeof(T) == typeof(float) || typeof(T) == typeof(decimal))
    //        {
    //            dynamic min = Minimum;
    //            dynamic max = Maximum;
    //            return max - min;
    //        }
    //        throw new InvalidOperationException("Length can only be calculated for numeric types.");
    //    }
    //}

    // 2
    //public class Helper
    //{
    //    public static void ReverseArrayList(ArrayList arrayList)
    //    {
    //        if (arrayList == null || arrayList.Count <= 1)
    //        {
    //            return;
    //        }

    //        int left = 0;
    //        int right = arrayList.Count - 1;

    //        while (left < right)
    //        {
    //            object temp = arrayList[left];
    //            arrayList[left] = arrayList[right];
    //            arrayList[right] = temp;

    //            left++;
    //            right--;
    //        }
    //    }
    //}

    // 3
    //public static class NumberHelper
    //{
    //    public static List<int> GetEvenNumbers(List<int> numbers)
    //    {
    //        List<int> evenNumbers = new List<int>();

    //        foreach (int number in numbers)
    //        {
    //            if (number % 2 == 0)
    //            {
    //                evenNumbers.Add(number);
    //            }
    //        }

    //        return evenNumbers;
    //    }
    //}

    // 4
    //public class FixedSizeList<T>
    //{
    //    private List<T> _items;
    //    private int _capacity;

    //    public FixedSizeList(int capacity)
    //    {
    //        if (capacity <= 0)
    //            throw new ArgumentException("Capacity must be greater than zero.");

    //        _capacity = capacity;
    //        _items = new List<T>(_capacity);
    //    }

    //    public void Add(T item)
    //    {
    //        if (_items.Count >= _capacity)
    //        {
    //            Console.WriteLine("Cannot add more elements. List is full.");
    //            return;
    //        }

    //        _items.Add(item);
    //    }

    //    public T Get(int index)
    //    {
    //        if (index < 0 || index >= _items.Count)
    //        {
    //            Console.WriteLine("Invalid index.");
    //            return default(T);
    //        }

    //        return _items[index];
    //    }

    //    public int Count()
    //    {
    //        return _items.Count;
    //    }

    //    public bool IsFull()
    //    {
    //        return _items.Count >= _capacity;
    //    }
    //}

    // 5
    //public static class StringHelper
    //{
    //    public static int FirstUniqChar(string s)
    //    {
    //        Dictionary<char, int> charCount = new Dictionary<char, int>();

    //        foreach (char c in s)
    //        {
    //            if (charCount.ContainsKey(c))
    //                charCount[c]++;
    //            else
    //                charCount[c] = 1;
    //        }

    //        for (int i = 0; i < s.Length; i++)
    //        {
    //            if (charCount[s[i]] == 1)
    //                return i;
    //        }

    //        return -1;
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            #region 1-Create a generic Range<T> class that represents a range of values from a minimum value to a maximum value. The range should support basic operations such as checking if a value is within the range and determining the length of the range.

            //var intRange = new Range<int>(10, 20);
            //Console.WriteLine(intRange.IsInRange(15));
            //Console.WriteLine(intRange.IsInRange(25));
            //Console.WriteLine(intRange.Length());

            //var doubleRange = new Range<double>(5.5, 10.5);
            //Console.WriteLine(doubleRange.IsInRange(7.5));
            //Console.WriteLine(doubleRange.Length());
            #endregion

            #region 2-You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.

            //ArrayList arrayList = new ArrayList { 1, 2, 3, 4, 5 };
            //Helper.ReverseArrayList(arrayList);
            //Console.WriteLine("Reversed ArrayList:");
            //foreach (var item in arrayList)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            #endregion

            #region 3-You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> evenNumbers = NumberHelper.GetEvenNumbers(numbers);

            //Console.WriteLine("Even numbers:");
            //foreach (var number in evenNumbers)
            //{
            //    Console.Write(number + " ");
            //}
            //Console.WriteLine();
            #endregion

            #region 4-implement a custom list called FixedSizeList<T> with a predetermined capacity. This list should not allow more elements than its capacity and should provide clear messages if one tries to exceed it or access invalid indices.
            //FixedSizeList<int> list = new FixedSizeList<int>(3);
            //list.Add(10);
            //list.Add(20);
            //list.Add(30);
            //list.Add(40);

            //Console.WriteLine("Element at index 1: " + list.Get(1));
            //Console.WriteLine("Element at index 5: " + list.Get(5));
            //Console.WriteLine("Is the list full? " + list.IsFull());
            #endregion

            #region 5-Given a string, find the first non-repeated character in it and return its index. If there is no such character, return 
            //string input = "loveleetcode";
            //int result = StringHelper.FirstUniqChar(input);
            //Console.WriteLine(result);
            #endregion
        }
    }
}
