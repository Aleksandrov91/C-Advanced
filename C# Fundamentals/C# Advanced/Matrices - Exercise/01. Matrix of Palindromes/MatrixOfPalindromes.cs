using System;
using System.Linq;

namespace _01.Matrix_of_Palindromes
{
    public class MatrixOfPalindromes
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();

            var matrixRows = input[0];
            var matrixCols = input[1];

            string[][] palindromeMatrix = new string[matrixRows][];
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int rowIndex = 0; rowIndex < palindromeMatrix.Length; rowIndex++)
            {
                palindromeMatrix[rowIndex] = new string[matrixCols];

                for (int colIndex = 0; colIndex < palindromeMatrix[rowIndex].Length; colIndex++)
                {
                    string currentPalindrome = $"{alphabet[rowIndex]}{alphabet[colIndex + rowIndex]}{alphabet[rowIndex]}";
                    palindromeMatrix[rowIndex][colIndex] = currentPalindrome;
                }
            }

            foreach (var palindrome in palindromeMatrix)
            {
                Console.WriteLine(string.Join(" ", palindrome));
            }
        }
    }
}
