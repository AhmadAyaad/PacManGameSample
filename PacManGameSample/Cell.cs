using System;
using System.Collections.Generic;
using System.Text;

namespace PacManGameSample
{
    public class Cell
    {
        public string Description { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"X: {X} , Y: {Y} ";
        }
        public override bool Equals(object obj)
        {
            if (obj is Cell cell)
                if ((cell.X == X) && (cell.Y == Y))
                    return true;
            return false;
        }

        
    }
}
