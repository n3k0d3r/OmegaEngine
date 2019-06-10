using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace OmegaEngine
{
    static class Globals
    {
        public static GraphicsDevice graphicsDevice;
        public static SpriteBatch spriteBatch;
        public static RenderTarget2D renderTarget;

        public static Texture2D spriteSheet;
        public static int SPR_WIDTH;
        public static int SPR_HEIGHT;
        public static int LAYER_DEPTH;

        public static GridMap grid;
    }
}
