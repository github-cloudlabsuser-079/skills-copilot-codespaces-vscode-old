using System;

class Program
{
    const int MAX = 100;

    static int Sum(int[] arr, int n)
    {
        int result = 0;
        for (int i = 0; i < n; i++)
        {
            result += arr[i];
        }
        return result;
    }

    static void Main()
    {
        int n;
        Console.Write("Enter the number of elements (1-100): ");
        if (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > MAX)
        {
            Console.WriteLine("Invalid input. Please provide a digit ranging from 1 to 100.");
            Environment.Exit(1);
        }

        int[] arr = new int[n];

        Console.WriteLine($"Enter {n} integers:");
        for (int i = 0; i < n; i++)
        {
            if (!int.TryParse(Console.ReadLine(), out arr[i]))
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
                Environment.Exit(1);
            }
        }

        int total = Sum(arr, n);

        Console.WriteLine($"Sum of the numbers: {total}");

        // No need to free memory in C#, as it's managed by the runtime.
    }
}

class ProgramTests
{
    static void Main()
    {
        TestSum();
        TestInvalidInput();
    }

    static void TestSum()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int expected = 15;
        int actual = Program.Sum(arr, arr.Length);
        if (actual != expected)
        {
            Console.WriteLine($"TestSum failed: expected {expected}, but got {actual}");
        }
        else
        {
            Console.WriteLine("TestSum passed");
        }
    }

    static void TestInvalidInput()
    {
        // Test invalid input
        string[] inputs = { "0", "101", "abc", "1.5" };
        foreach (string input in inputs)
        {
            Console.WriteLine($"Testing invalid input: {input}");
            Console.SetIn(new System.IO.StringReader(input + "\n"));
            Console.SetOut(new System.IO.StringWriter());
            Program.Main();
            string output = Console.Out.ToString();
            if (!output.Contains("Invalid input"))
            {
                Console.WriteLine("TestInvalidInput failed");
            }
            else
            {
                Console.WriteLine("TestInvalidInput passed");
            }
        }
    }
}