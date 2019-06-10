using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace OmegaEngine
{
    public sealed class EngineManager
    {
        private static readonly Lazy<EngineManager> lazy = new Lazy<EngineManager>(() => new EngineManager());

        public static EngineManager Instance { get { return lazy.Value; } }

        private EngineManager()
        {
        }

        public void Initialize(GraphicsDevice graphicsDevice, SpriteBatch spriteBatch, Texture2D spriteSheet, int depth, int height, int width)
        {
            Globals.graphicsDevice = graphicsDevice;
            Globals.renderTarget = new RenderTarget2D(graphicsDevice, 320, 320, false, graphicsDevice.PresentationParameters.BackBufferFormat, DepthFormat.Depth24);
            Globals.spriteBatch = spriteBatch;
            Globals.spriteSheet = spriteSheet;
            Globals.LAYER_DEPTH = depth;
            Globals.SPR_HEIGHT = height;
            Globals.SPR_WIDTH = width;

            Globals.grid = new GridMap();
        }

        public void Draw()
        {
            Globals.grid.Draw();
        }
    }
}
