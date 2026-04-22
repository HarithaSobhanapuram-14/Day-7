using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Step 2: Take input from user
        Console.WriteLine("Enter the size of the array:");
        int size = int.Parse(Console.ReadLine());

        int[] arr = new int[size];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the element to be searched:");
        int element = int.Parse(Console.ReadLine());

        Console.WriteLine("Linear Search Result:");

        // Step 3: Call the method
        int linearSearchResult = LinearSearch(arr, element);

        // Step 4: Display result
        if (linearSearchResult != -1)
        {
            Console.WriteLine($"Element found at index: {linearSearchResult}");
        }
        else
        {
            Console.WriteLine("Element not found in the array.");
        }
    }

    // Step 1: Linear Search Method
    static int LinearSearch(int[] arr, int element)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == element)
            {
                return i;
            }
        }
        return -1;
    }
}