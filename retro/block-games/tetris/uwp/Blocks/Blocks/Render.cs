using Microsoft.Graphics.Canvas;
using Windows.UI;

namespace Blocks
{
    internal static class Render
    {
        private const int _cellSize = 15;

        public static void Draw(CanvasDrawingSession session, Game game)
        {
            DrawGrid(session, game.Field.Size.Width, game.Field.Size.Height);
            DrawFigure(session, game);
            DrawCells(session, game.Field);
        }

        private static void DrawGrid(CanvasDrawingSession session, int w, int h)
        {
            int width = _cellSize * w;
            int height = _cellSize * h;

            int x = 100;
            int y = 100;

            for (int i = 0; i < h + 1; i++)
            {
                session.DrawLine(x, y, x + width, y, Colors.AntiqueWhite);
                y += _cellSize;
            }

            x = 100;
            y = 100;

            for (int i = 0; i < w + 1; i++)
            {
                session.DrawLine(x, y, x, y + height, Colors.Gray);
                x += _cellSize;

            }
        }

        private static void DrawFigure(CanvasDrawingSession session, Game game)
        {
            var side = _cellSize - 4;
            var pattern = game.Figure.Pattern;
            foreach(var coord in pattern)
            {

                int x = 100 + 2 + (game.X + coord[0]) * _cellSize;
                int y = 100 + 2 + (game.Y + coord[1]) * _cellSize;

                session.FillRectangle(x, y, side, side, Colors.Red);
            }
        }

        private static void DrawCells(CanvasDrawingSession session, Field field)
        {
            int side = (_cellSize - 4);

            for (int x = 0; x < field.Size.Width; x++)
            {
                for (int y = 0; y < field.Size.Height; y++)
                {
                    if (!field.IsFree(x, y))
                    {
                        int px = 100 + 2 + x * _cellSize;
                        int py = 100 + 2 + y * _cellSize;

                        session.FillRectangle(px, py, side, side, Colors.Green);
                    }
                }
            }
        }
    }
}
