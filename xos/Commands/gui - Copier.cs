using System;
using System.Drawing;
using Cosmos.System.Graphics;

namespace xos.Commands
{
    public class MyGui
    {
        private static VGACanvas _canvas;

        public void Initialize()
        {
            Mode mode = new Mode(800, 600, ColorDepth.ColorDepth32);
            _canvas = new VGACanvas(mode);

            DrawGui();

            Console.ReadKey();
        }

        private static void DrawGui()
        {
            _canvas.Clear(Color.Green);

            // Assuming Mode class has Width and Height properties
            DrawSidebar((int)_canvas.Mode.Width, (int)_canvas.Mode.Height);

            _canvas.Display();
        }

        private static void DrawSidebar(int screenWidth, int screenHeight)
        {
            int sidebarWidth = 100;
            Color sidebarColor = Color.Gray;

            int startX = screenWidth - sidebarWidth;
            int startY = 0;

            _canvas.DrawFilledRectangle(sidebarColor, startX, startY, sidebarWidth, screenHeight);
        }
    }
}