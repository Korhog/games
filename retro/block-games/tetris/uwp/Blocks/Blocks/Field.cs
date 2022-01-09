using System.Drawing;

namespace Blocks
{
    internal class Field
    {
        private int[,] _cells;

        public int[,] Cells => _cells;

        public Size Size { get; private set; }

        public Field() : this(10, 20) { }

        public Field(int w, int h)
        {
            Size = new Size(w, h);
            _cells = new int[w,h];
        }

        public bool IsFree(int x, int y)
        {
            return _cells[x, y] == 0;
        }
        
        public void Put(int x, int y, Figure figure)
        {
            var pattern = figure.Pattern;
            foreach (var coord in pattern)
            {

                int px = x + coord[0];
                int py = y + coord[1];

                if (px < 0 || px > Size.Width - 1 || py < 0 || py > Size.Height - 1)
                    continue;

                _cells[px, py] = 1;
            }            
        }
    }
}
