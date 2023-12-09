using System;
using System.Collections.Generic;

public class Program
{
    public static bool AreParanthesesBalanced(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in input)
        {
            switch (c)
            {
                case '(':
                case '[':
                case '{':
                    stack.Push(c);
                    break;
                case ')':
                    if (stack.Count == 0 || stack.Pop() != '(')
                    {
                        return false;
                    }
                    break;
                case ']':
                    if (stack.Count == 0 || stack.Pop() != '[')
                    {
                        return false;
                    }
                    break;
                case '}':
                    if (stack.Count == 0 || stack.Pop() != '{')
                    {
                        return false;
                    }
                    break;
            }
        }

        return stack.Count == 0;
    }

    static void Main(string[] args)
    {
        RunTests();
    }

    // BEGIN: TestCases
    public static void RunTests()
    {
        // Test case 1: Balanced parentheses
        string input1 = "()";
        bool expected1 = true;
        bool result1 = AreParanthesesBalanced(input1);
        Console.WriteLine($"Input: {input1}, Expected: {expected1}, Result: {result1}");

        // Test case 2: Balanced parentheses with different types
        string input2 = "()[]{}";
        bool expected2 = true;
        bool result2 = AreParanthesesBalanced(input2);
        Console.WriteLine($"Input: {input2}, Expected: {expected2}, Result: {result2}");

        // Test case 3: Unbalanced parentheses
        string input3 = "(]";
        bool expected3 = false;
        bool result3 = AreParanthesesBalanced(input3);
        Console.WriteLine($"Input: {input3}, Expected: {expected3}, Result: {result3}");

        // Test case 4: Unbalanced parentheses with incorrect order
        string input4 = "([)]";
        bool expected4 = false;
        bool result4 = AreParanthesesBalanced(input4);
        Console.WriteLine($"Input: {input4}, Expected: {expected4}, Result: {result4}");

        // Test case 5: Balanced parentheses with different types and nested brackets
        string input5 = "{[]}";
        bool expected5 = true;
        bool result5 = AreParanthesesBalanced(input5);
        Console.WriteLine($"Input: {input5}, Expected: {expected5}, Result: {result5}");
    }
    // END: TestCases
}