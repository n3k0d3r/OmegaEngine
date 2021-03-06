﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace OmegaEngine
{
    class TileMap
    {
        private Texture2D Texture { get; set; }
        private Color Fill { get; set; }

        public TileMap(Texture2D texture, Color? color = null)
        {
            Texture = texture;
            Fill = color ?? Color.White;
        }

        public void Draw(Rectangle dimensions)
        {
            Globals.spriteBatch.Draw(Texture, dimensions, new Rectangle(0, 0, 32, 32), Fill);
        }
    }
}
