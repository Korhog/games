
using System;
using System.Drawing;

namespace Blocks
{
    internal class Game
    {
        private Size _size = new Size(10, 15);

        private readonly Field _field = new Field(10,15);
        public Field Field => _field;

        private readonly Figure _figure = new Figure();

        public Figure Figure => _figure;

        private int _y = 0;
        private int _x = 0;
        private Random _rand;

        public int X => _x;
        public int Y => _y;

        public Game()
        {
            _rand = new Random();
            _x = _rand.Next(9);
        }

        public void Update()
        {
            /*
            if(_y < _size.Height - 1 && _field.IsFree(_x, _y+1))
            {
                _y++;
                return;
            }

            _field.Put(_x, _y, _figure);
            _y = 0;
            _x = _rand.Next(9);
            */
        }

        public void RotateUCW() => _figure.RotateUCW();
        public void RotateCW() => _figure.RotateCW();

        public void Next() => _figure.Next();        
    }
}
