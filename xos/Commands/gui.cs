using Cosmos.System.Graphics;
using System.Drawing;
using IL2CPU.API.Attribs;

namespace xos.Commands
{
    public static class GUI
    {
        public static Canvas canvas;
        [ManifestResourceStream(ResourceName = "xos.images.xp.bmp")] public static byte[] image_background;
        public static Bitmap bmp = new Bitmap(image_background);
        public static void Initialize(uint screenWidth, uint screenHeight)
        {
            canvas = FullScreenCanvas.GetFullScreenCanvas(new Mode(screenWidth, screenHeight, ColorDepth.ColorDepth32));
            // Logique pour initialiser le GUI, comme dessiner un fond d'écran, etc.
        }

        public static void Draw()
        {
            canvas.DrawImage(bmp,0,0);

            canvas.Display();
        }

    }
}
