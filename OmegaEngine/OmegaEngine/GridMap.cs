using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace OmegaEngine
{
    class GridMap
    {
        private List<LayerMap> Grid { get; set; }

        public GridMap()
        {
            Grid = new List<LayerMap>();
            for (int layer = 0; layer < Globals.LAYER_DEPTH; layer++)
                Grid.Add(new LayerMap(Globals.spriteSheet, Globals.SPR_HEIGHT, Globals.SPR_WIDTH));
        }

        public void Draw()
        {
            Globals.graphicsDevice.SetRenderTarget(Globals.renderTarget);

            Globals.graphicsDevice.Clear(Color.Black);

            Globals.spriteBatch.Begin();
            foreach (LayerMap layer in Grid)
                layer.Draw();
            Globals.spriteBatch.End();

            Globals.graphicsDevice.SetRenderTarget(null);

            Globals.spriteBatch.Begin();
            Globals.spriteBatch.Draw(Globals.renderTarget, new Rectangle(0, 0, Globals.graphicsDevice.PresentationParameters.BackBufferWidth, Globals.graphicsDevice.PresentationParameters.BackBufferHeight), Color.White);
            Globals.spriteBatch.End();
        }
    }
}
