/*
Problem 12. Index of letters

Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array.
 */
using System;
    class IndexLetters
    {
        static void Main()
        {
            int n = 26;
            char[] alphabet = new char[n];

            for (int i = 0, j = 97; i < alphabet.Length; j++, i++)
            {
                alphabet[i] = (char)j;

            }
            Console.Write("Enter word with small letters: ");
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (word[i] == alphabet[j])
                    {
                        Console.WriteLine("The letter {0} is on {1} index", word[i], j);
                    }
                }
            }
        }
    }

