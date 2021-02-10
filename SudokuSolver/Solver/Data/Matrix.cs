using System.Collections.Generic;

namespace Solver.Data
{
    public class Matrix
    {
        private readonly List<int>[,] Fields = new List<int>[9, 9];

        public Matrix(Sudoku sudoku)
        {
            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    if(sudoku.Fields[i, j] == SudokuField.Unknown)
                    {
                        Fields[i, j] = CreateFullField();
                    }
                    else
                    {
                        Fields[i, j] = new List<int> { (int)sudoku.Fields[i, j] };
                    }
                }
            }
        }

        private List<int> CreateFullField()
        {
            List<int> fullField = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            return fullField;
        }
    }
}
