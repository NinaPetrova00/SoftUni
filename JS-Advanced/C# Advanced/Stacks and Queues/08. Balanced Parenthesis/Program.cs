<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine()
                .ToCharArray();

            Stack<char> stack = new Stack<char>(input);
            char[] brackets = { '(', '{', '[' };

            bool isBalanced = true;

            foreach (var bracket in input)
            {
                if (brackets.Contains(bracket))
                {
                    stack.Push(bracket);
                    continue;
                }

                if (stack.Count < 0)
                {
                    isBalanced = false;
                    break;
                }

                if (stack.Peek() == '(' && bracket == ')')
                {
                    stack.Pop();
                }
                else if (stack.Peek() == '[' && bracket == ']')
                {
                    stack.Pop();
                }
                else if (stack.Peek() == '{' && bracket == '}')
                {
                    stack.Pop();
                }
                else
                {
                    isBalanced = false;
                    break;
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine()
                .ToCharArray();

            Stack<char> stack = new Stack<char>(input);
            char[] brackets = { '(', '{', '[' };

            bool isBalanced = true;

            foreach (var bracket in input)
            {
                if (brackets.Contains(bracket))
                {
                    stack.Push(bracket);
                    continue;
                }

                if (stack.Count < 0)
                {
                    isBalanced = false;
                    break;
                }

                if (stack.Peek() == '(' && bracket == ')')
                {
                    stack.Pop();
                }
                else if (stack.Peek() == '[' && bracket == ']')
                {
                    stack.Pop();
                }
                else if (stack.Peek() == '{' && bracket == '}')
                {
                    stack.Pop();
                }
                else
                {
                    isBalanced = false;
                    break;
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
