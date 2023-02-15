﻿using System;
using System.Linq;

namespace RPP_Programirane_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                switch (command[0])
                {
                    case "Reverse":
                        Array.Reverse(arr);
                        break;
                    case "Distinct":
                        arr = arr.Distinct().ToArray();
                        break;
                    case "Replace":
                        int index = int.Parse(command[1]);
                        string newWord = command[2];
                        arr[index] = newWord;
                        break;
                    case "Print":
                        var result = arr.Where(x => x.StartsWith(command[1])).ToArray();
                        Console.WriteLine(string.Join(" ", arr));
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}

