namespace Blocks
{
    internal class Figure
    {
        private int _index = 0;
        private int _figure = 2;

        private readonly int[][][][] a = new int[][][][] {
            // O
            new int[][][] {            
                new int[4][]
                {
                    new int[2] {-1,-1},
                    new int[2] { 0,-1},
                    new int[2] { 0, 0},
                    new int[2] {-1, 0}
                },
                new int[4][]
                {
                    new int[2] {-1,-1},
                    new int[2] { 0,-1},
                    new int[2] { 0, 0},
                    new int[2] {-1, 0}
                },
                new int[4][]
                {
                    new int[2] {-1,-1},
                    new int[2] { 0,-1},
                    new int[2] { 0, 0},
                    new int[2] {-1, 0}
                },
                new int[4][]
                {
                    new int[2] {-1,-1},
                    new int[2] { 0,-1},
                    new int[2] { 0, 0},
                    new int[2] {-1, 0}
                }
            },

            // J
            new int[][][]
            {            
                new int[4][]
                {
                    new int[2] {-1,0},
                    new int[2] {0,0},
                    new int[2] {1,0},
                    new int[2] {1,1},
                },
                new int[4][]
                {
                    new int[2] {-1,1},
                    new int[2] {0,1},
                    new int[2] {0,0},
                    new int[2] {0,-1},
                },
                new int[4][]
                {
                    new int[2] {-1,-1},
                    new int[2] {-1,0},
                    new int[2] {0,0},
                    new int[2] {1,0},
                },
                new int[4][]
                {
                    new int[2] {0,1},
                    new int[2] {0,0},
                    new int[2] {0,-1},
                    new int[2] {1,-1},
                },
            },

            // L
            new int[][][]
            {
                new int[4][]
                {
                    new int[2] {0, -2},
                    new int[2] {0, -1},
                    new int[2] {0, 0},
                    new int[2] {1, 0},
                },
                new int[4][]
                {
                    new int[2] {-1, 0},
                    new int[2] {-1, -1},
                    new int[2] { 0, -1},
                    new int[2] { 1, -1},
                },
                new int[4][]
                {
                    new int[2] {-1, -2},
                    new int[2] {0, -2},
                    new int[2] {0, -1},
                    new int[2] {0, 0},
                },
                 new int[4][]
                {
                    new int[2] {-1,-1},
                    new int[2] {0,-1},
                    new int[2] {1,-1},
                    new int[2] {1,-2},
                },
            },

            // I
            new int[][][]
            {
                new int[4][]
                {
                    new int[2] {-2, 0},
                    new int[2] {-1, 0},
                    new int[2] {0, 0},
                    new int[2] {1, 0},
                },
                new int[4][]
                {
                    new int[2] {-1, -2},
                    new int[2] {-1, -1},
                    new int[2] {-1, 0},
                    new int[2] {-1, 1},
                },
                new int[4][]
                {
                    new int[2] {-2, -1},
                    new int[2] {-1, -1},
                    new int[2] {0, -1},
                    new int[2] {1, -1},
                },
                 new int[4][]
                {
                    new int[2] {0, -2},
                    new int[2] {0, -1},
                    new int[2] {0, 0},
                    new int[2] {0, 1},
                },
            },

            // S
            new int[][][]
            {
                new int[4][]
                {
                    new int[2] {-1, -1},
                    new int[2] {0, -1},
                    new int[2] {0, -2},
                    new int[2] {1, -2},
                },
                new int[4][]
                {
                    new int[2] {0, -2},
                    new int[2] {0, -1},
                    new int[2] {1, -1},
                    new int[2] {1, 0},
                },
                new int[4][]
                {
                    new int[2] {-1, 0},
                    new int[2] {0, 0},
                    new int[2] {0, -1},
                    new int[2] {1, -1},
                },
                 new int[4][]
                {
                    new int[2] {-1, -2},
                    new int[2] {-1, -1},
                    new int[2] {0, -1},
                    new int[2] {0, 0},
                },
            },

            // Z
            new int[][][]
            {
                new int[4][]
                {
                    new int[2] {-1, -2},
                    new int[2] {0, -2},
                    new int[2] {0, -1},
                    new int[2] {1, -1},
                },
                new int[4][]
                {
                    new int[2] {0, 0},
                    new int[2] {0, -1},
                    new int[2] {1, -1},
                    new int[2] {1, -2},
                },
                new int[4][]
                {
                    new int[2] {-1, -1},
                    new int[2] {0, -1},
                    new int[2] {0, 0},
                    new int[2] {1, 0},
                },
                 new int[4][]
                {
                    new int[2] {-1, 0},
                    new int[2] {-1, -1},
                    new int[2] {0, -1},
                    new int[2] {0, -2},
                },
            },

            // T
            new int[][][]
            {
                new int[4][]
                {
                    new int[2] {-1, -1},
                    new int[2] {0, -1},
                    new int[2] {0,  0},
                    new int[2] {1, -1},
                },
                new int[4][]
                {
                    new int[2] {-1, -1},
                    new int[2] {0, -2},
                    new int[2] {0, -1},
                    new int[2] {0, 0},
                },
                new int[4][]
                {
                    new int[2] {-1, -1},
                    new int[2] {0, -1},
                    new int[2] {0,  -2},
                    new int[2] {1, -1},
                },
                 new int[4][]
                {
                    new int[2] {1, -1},
                    new int[2] {0, -2},
                    new int[2] {0, -1},
                    new int[2] {0, 0},
                },
            },
        };

            

        public int[][] Pattern => a[_figure][_index];
        
        public void RotateCW()
        {
            if(_index == 3)
            {
                _index = 0;
            }
            else
            {
                _index++;
            }
        }

        public void RotateUCW()
        {
            if (_index == 0)
            {
                _index = 3;
            }
            else
            {
                _index--;
            }
        }

        public void Next()
        {
            if (_figure == 6)
            {
                _figure = 0;
            }
            else
            {
                _figure++;
            }
        }
    }
}
