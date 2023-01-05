using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace NotEdible.models
{
    public class Map
    {
        private Point _mapSize = new Point(10, 10);
        private Point _tileSize;
        private Tile[,] _map;
        private List<Texture2D> _mapTextures;

        public Map()
        {
            _map = new Tile[_mapSize.X, _mapSize.Y];
            _mapTextures = new List<Texture2D>
            {

            };
        }
    }
}
