using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoverOf3
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int[] matrixDimension = input.Split(' ').Select(int.Parse).ToArray();
            int[,] matrix = new int[matrixDimension[0], matrixDimension[1]];
            int NumberMovesAndDirections = int.Parse(Console.ReadLine());

            int sum = 0;

            var direction = new List<string>();
            var movesInput = new List<int>();

            for (int i = 0; i < NumberMovesAndDirections; i++)
            {
                var wordAndMove = Console.ReadLine().Split(' ').ToArray();
                direction.Add(wordAndMove[0]);
                movesInput.Add(int.Parse(wordAndMove[1]));

            }

            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    matrix[row, col] = sum;
                    sum += 3;

                }
                sum = matrix[row, 1];
            }
            int act = matrix[matrix.GetLength(0) - 1, 0];
            int colIndex = 0;
            int rowIndex = 0;
            int index = 0;
            rowIndex = matrix.GetLength(0)-1;
            colIndex = 0;
            for (int moves = 0; moves < movesInput.Count; moves++)
            {
                var currentMove = direction[moves];
                if (currentMove == "UR" || currentMove == "RU")
                {
                    for (int i = 1; i < movesInput[moves]; i++)
                    {
                        if ( colIndex + i < matrix.GetLength(1) && rowIndex - i >= 0)
                        {

                            act += matrix[rowIndex - i,colIndex + i];                           
                            matrix[rowIndex - i, colIndex + i] = 0;

                            index = i;
                            
                        }
                        
                        
                    }
                    if (colIndex + index < matrix.GetLength(1) && rowIndex - index >= 0)
                    {



                        rowIndex = rowIndex - index;
                        colIndex = colIndex + index;
                    }
                }
                else if (currentMove == "RD" || currentMove == "DR")
                {
                    for (int i = 1; i < movesInput[moves]; i++)
                    {
                        if (rowIndex + i < matrix.GetLength(0) && colIndex + i < matrix.GetLength(1))
                        {

                            act += matrix[rowIndex + i, colIndex + i];
                            
                            matrix[rowIndex + i, colIndex + i] = 0;
                            
                            index = i;
                        }

                    }
                    if (rowIndex + index < matrix.GetLength(0) && colIndex + index < matrix.GetLength(1))
                    {
                        colIndex = colIndex + index;
                        rowIndex = rowIndex + index;
                    }
                    
                }
                else if (currentMove == "DL" || currentMove == "LD")
                {
                    for (int i = 1; i < movesInput[moves]; i++)
                    {
                        if (rowIndex + i < matrix.GetLength(0) && colIndex - i >= 0)
                        {



                            act += matrix[rowIndex + i, colIndex - i];
                            
                            matrix[rowIndex + i, colIndex - i] = 0;
                            
                            index = i;
                        }

                    }
                    if (rowIndex + index < matrix.GetLength(0) && colIndex - index >= 0)
                    {


                        rowIndex = rowIndex + index;
                        colIndex = colIndex - index;
                    }
                }
                else if (currentMove == "LU" || currentMove == "UL")
                {
                    for (int i = 1; i < movesInput[moves]; i++)
                    {
                        if (rowIndex - i >= 0 && colIndex - i >= 0)
                        {
                            act += matrix[rowIndex - i, colIndex - i];
                            
                            matrix[rowIndex - i, colIndex - i] = 0;                           
                            index = i;
                        }
                    }
                    if (rowIndex - index >= 0 && colIndex - index >= 0)
                    {
                        rowIndex = rowIndex - index;
                        colIndex = colIndex - index; 
                    }
                    
                }
            }
            Console.WriteLine(act);
        }
    }
}
