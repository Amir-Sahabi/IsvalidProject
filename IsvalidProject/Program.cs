    using System;
using System.Collections.Generic;
namespace IsvalidProject
{
internal class Program

    {
        #region User Input

        static void Main(string[] args)
        {
            Console.Write("Enter the brackets: ");
            string input = Console.ReadLine();
            char[] brackets = input.ToCharArray();
            bool isValid = isValidBrackets(brackets);
            if (isValid)
            {
                Console.WriteLine("The brackets are valid.");
            }
            else
            {
                Console.WriteLine("The brackets are not valid.");
            }
            Console.ReadLine();
        }
        
        #endregion
        
        #region IsvalidBrackets

        public static bool isValidBrackets(char[] brackets)
        {
            // Create a stack to store the open brackets.
            Stack<char> stack = new Stack<char>();
            
            foreach (char bracket in brackets)
            {
                // If the bracket is an open bracket, push it onto the stack.
                if (bracket == '(' || bracket == '{' || bracket == '[')
                {
                    stack.Push(bracket);
                }
                // If the bracket is a closed bracket, pop the top element from the stack.
                else if (bracket == ')' || bracket == '}' || bracket == ']')
                {
                    char top = stack.Pop();
                    // If the top element of the stack is not the same type of bracket, the input is not valid.
                    if (top != '(' && bracket == ')' || top != '{' && bracket == '}' || top != '[' && bracket == ']')
                    {
                        return false;
                    }
                }
            }
            // If the stack is empty, the input is valid.
            return stack.Count == 0;
        }
        #endregion
    }
}

