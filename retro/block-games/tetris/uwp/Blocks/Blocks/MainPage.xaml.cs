using System;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;


// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace Blocks
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly Game _game = new Game();
        private DateTime _time;
        private TimeSpan _tick = TimeSpan.FromMilliseconds(300);

        public MainPage()
        {
            _time = DateTime.Now + _tick;
            Window.Current.CoreWindow.KeyDown += CoreWindow_KeyDown;
            this.InitializeComponent();
        }

        private void OnGridSizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void OnDraw(Microsoft.Graphics.Canvas.UI.Xaml.ICanvasAnimatedControl sender, Microsoft.Graphics.Canvas.UI.Xaml.CanvasAnimatedDrawEventArgs args)
        {            
            if (DateTime.Now > _time)
            {
                // 
                _game.Update();
                _time += _tick;
            }
            Render.Draw(args.DrawingSession, _game);
        }

        private void OnCanvasKeyDown(object sender, KeyRoutedEventArgs e)
        {

        }

        private void CoreWindow_KeyDown(Windows.UI.Core.CoreWindow sender, Windows.UI.Core.KeyEventArgs args)
        {
            if (args.VirtualKey == VirtualKey.Left)
            {
                _game.RotateUCW();
            }

            if (args.VirtualKey == VirtualKey.Right)
            {
                _game.RotateCW();
            }

            if (args.VirtualKey == VirtualKey.Space)
            {
                _game.Next();
            }
        }
    }
}
