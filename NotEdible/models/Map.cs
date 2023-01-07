using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace NotEdible.models
{
    public class Map
    {
        private Point _mapSize = new Point(5, 5);
        private Point _screenSize = new Point(1600, 900);
        private Point _tileSize;
        private Tile[,] _map;
        private List<Texture2D> _mapTextures;

        public Map()
        {
            _map = new Tile[_mapSize.X, _mapSize.Y];
            _mapTextures = new List<Texture2D>
            {
                Globals.content.Load<Texture2D>("MapTextures\\dirt_E"),
                Globals.content.Load<Texture2D>("MapTextures\\dirt_N"),
                Globals.content.Load<Texture2D>("MapTextures\\dirt_S"),
                Globals.content.Load<Texture2D>("MapTextures\\dirt_W")
                //Globals.content.Load<Texture2D>("dirt_test")
            };

            _tileSize.X = _mapTextures[0].Width;
            _tileSize.Y = _mapTextures[0].Height;

            System.Diagnostics.Debug.WriteLine(_tileSize.X + " is the width!" + _tileSize.Y + "is the height!");

            for (int x = 0; x <_mapSize.X; x++)
            {
                for (int y = 0; y < _mapSize.Y; y++)
                {
                    _map[x, y] = new Tile(_mapTextures[Utility.GetRandomNum(_mapTextures.Count)], TileToScreen(x, y), 0);
                }
            }
        }

        private Vector2 TileToScreen(int x, int y)
        {
            float posX = x - y;
            float posY = x + y;

            // Calculate the position and size of the tile in screen space
            Vector2 tilePosition = new Vector2(posX * _tileSize.X / 2 + 600, posY * _tileSize.Y / 2 + 100);
            return tilePosition;
        }

        public void Draw()
        {
            for (int x = 0; x < _mapSize.X; x++)
            {
                for (int y = 0; y < _mapSize.Y; y++)
                {
                    _map[x, y].Draw();
                }
            }
        }
    }
}
