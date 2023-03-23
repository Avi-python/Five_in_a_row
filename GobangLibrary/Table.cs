using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GobangLibrary
{
    public class Table
    {
        public static readonly int _width = 10; // const 編譯期間處理的，所以要記得build
        private Mark[,] _board;
        public Mark[,] Board { get { return _board; } set { _board = value; } }

        public Table()
        {
            _board = new Mark[_width, _width];
        }

        public void initTable()
        {
            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _width; j++)
                {
                    Board[i, j] = Mark.None;
                }
            }
        }

        public static bool OutOfBound(int x, int y) // 基本上不會有
        {
            return (x >= _width || x < 0 || y >= _width || y < 0);
        }
        public Mark this[int xRow, int yCol]
        {
            get
            {
                if (OutOfBound(xRow, yCol)) throw new ArgumentOutOfRangeException("xRow or yCol");
                return Board[xRow, yCol];
            }
            set
            {
                if (OutOfBound(xRow, yCol)) throw new ArgumentOutOfRangeException("xRow or yCol");
                Board[xRow, yCol] = value; // 要注意，因為value 可能型別不對
            }
        }

        #region 測試用Function
        public void ShowTable() // 測試用
        {
            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _width; j++)
                {
                    Console.Write($"{Board[i, j]}, ");
                }
                Console.WriteLine();
            }
        }

        #endregion
    }

    public enum Mark
    {
        None,
        Black,
        White
    }


}
