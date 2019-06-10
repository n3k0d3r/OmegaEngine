using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace OmegaEngine
{
    class LayerMap
    {
        private List<List<TileMap>> Layer { get; set; }
        private Texture2D Spritesheet { get; set; }

        public LayerMap(Texture2D spriteSheet, int height, int width)
        {
            Spritesheet = spriteSheet;
            Layer = new List<List<TileMap>>();
            for (int row = 0; row < height; row++)
            {
                List<TileMap> newRow = new List<TileMap>();
                for (int tile = 0; tile < width; tile++)
                {
                    newRow.Add(new TileMap(Spritesheet));
                }
                Layer.Add(newRow);
            }
        }

        public void Draw()
        {
            for (int row = 0; row < Layer.Count; row++)
                for (int tile = 0; tile < Layer[row].Count; tile++)
                    Layer[row][tile].Draw(new Microsoft.Xna.Framework.Rectangle(0 + tile * 32, 0 + row * 32, 32, 32));
        }
    }
}
