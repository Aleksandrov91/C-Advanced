using System;

namespace ChessValidator
{
    public class ChessValidator
    {
        public static void Main()
        {
            var chess = new string[8][];

            for (int i = 0; i < chess.Length; i++)
            {
                chess[i] = Console.ReadLine()
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            }

            var commands = Console.ReadLine();
            while (commands != "END")
            {
                var startRow = int.Parse(commands[1].ToString());
                var startCol = int.Parse(commands[2].ToString());
                var targetRow = int.Parse(commands[4].ToString());
                var targetCol = int.Parse(commands[5].ToString());

                if (!IsInMatrix(chess, startRow, startCol))
                {
                    commands = Console.ReadLine();
                    continue;
                }

                if (chess[startRow][startCol] == "x")
                {
                    Console.WriteLine("There is no such a piece!");
                    commands = Console.ReadLine();
                    continue;
                }

                switch (commands[0])
                {
                    case 'K':
                        if (ValidateKing(chess, targetRow, targetCol, startRow, startCol))
                        {
                            if (PrintOutOfBoard(chess, targetRow, targetCol))
                            {
                                chess[startRow][startCol] = "x";
                                chess[targetRow][targetCol] = "K";
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Move!");
                        }
                        break;
                    case 'R':
                        if (ValidateRook(chess, targetRow, targetCol, startRow, startCol))
                        {
                            if (PrintOutOfBoard(chess, targetRow, targetCol))
                            {
                                chess[startRow][startCol] = "x";
                                chess[targetRow][targetCol] = "R";
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Move!");
                        }
                        break;
                    case 'B':
                        if (ValidateBishop(chess, targetRow, targetCol, startRow, startCol))
                        {
                            if (PrintOutOfBoard(chess, targetRow, targetCol))
                            {
                                chess[startRow][startCol] = "x";
                                chess[targetRow][targetCol] = "B";
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Move!");
                        }
                        break;
                    case 'Q':
                        if (ValidateRook(chess, targetRow, targetCol, startRow, startCol) ||
                            ValidateBishop(chess, targetRow, targetCol, startRow, startCol) ||
                            ValidateKing(chess, targetRow, targetCol, startRow, startCol))
                        {
                            if (PrintOutOfBoard(chess, targetRow, targetCol))
                            {
                                chess[startRow][startCol] = "x";
                                chess[targetRow][targetCol] = "Q";
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Move!");
                        }
                        break;
                    case 'N':
                        if (ValidateKnight(chess, targetRow, targetCol, startRow, startCol))
                        {
                            if (PrintOutOfBoard(chess, targetRow, targetCol))
                            {
                                chess[startRow][startCol] = "x";
                                chess[targetRow][targetCol] = "N";
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Move!");
                        }

                        break;
                    case 'P':
                        if (ValidatePown(chess, targetRow, targetCol, startRow, startCol))
                        {
                            if (PrintOutOfBoard(chess, targetRow, targetCol))
                            {
                                chess[startRow][startCol] = "x";
                                chess[targetRow][targetCol] = "P";
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Move!");
                        }
                        break;
                }

                commands = Console.ReadLine();
            }

            foreach (var cell in chess)
            {
                Console.WriteLine(string.Join(" ", cell));
            }
        }

        private static bool ValidateKnight(string[][] chess, int targetRow, int targetCol, int startRow, int startCol)
        {
            //if (startRow - 2 == targetRow && startCol - 1 == targetCol ||
            //    startRow - 2 == targetRow && startCol + 1 == targetCol ||
            //    startRow + 2 == targetRow && startCol - 1 == targetCol ||
            //    startRow + 2 == targetRow && startCol + 1 == targetCol ||
            //    startCol - 2 == targetCol && startRow - 1 == targetCol ||
            //    startCol - 2 == targetCol && startRow + 1 == targetCol ||
            //    startCol + 2 == targetCol && startRow - 1 == targetCol ||
            //    startCol + 2 == targetCol && startRow + 1 == targetCol)
            //{
            //    return true;
            //}

            for (int rowIndex = startRow - 2; rowIndex < startRow + 2; rowIndex++)
            {
                for (int col = startCol - 1; col < startCol + 1; col++)
                {
                    if (rowIndex == 0 || col == 0)
                    {
                        continue;
                    }
                }
            }

            return false;
        }

        private static bool ValidateBishop(string[][] chess, int targetRow, int targetCol, int startRow, int startCol)
        {
            if (targetRow - targetCol == startRow - startCol ||
                targetRow + targetCol == startRow + startCol)
            {
                return true;
            }

            return false;
        }

        private static bool ValidateRook(string[][] chess, int targetRow, int targetCol, int startRow, int startCol)
        {
            if (targetRow == startRow || targetCol == startCol)
            {
                return true;
            }

            return false;
        }

        private static bool ValidateKing(string[][] chess, int targetRow, int targetCol, int startRow, int startCol)
        {
            if (targetRow == startRow + 1 || targetRow == startRow - 1 ||
                targetCol == startCol - 1 || targetCol == startCol + 1)
            {
                return true;
            }
            else if (targetRow == startRow - 1 && targetRow == targetRow + 1 ||
                    targetCol == startRow + 1 && targetCol == startCol + 1)
            {
                return true;
            }

            return false;
        }

        private static bool ValidatePown(string[][] chess, int targetRow, int targetCol, int startRow, int startCol)
        {
            if (targetRow == startRow - 1)
            {
                return true;
            }

            return false;
        }

        private static bool IsInMatrix(string[][] chess, int startRow, int startCol)
        {
            return startRow >= 0 && startRow < chess.Length && startCol >= 0 && startCol < chess[startRow].Length;
        }

        private static bool PrintOutOfBoard(string[][] chess, int targetRow, int targetCol)
        {
            if (IsInMatrix(chess, targetRow, targetCol))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Move go out of board!");
                return false;
            }
        }
    }
}
