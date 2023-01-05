using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace NotEdible.models
{
    public class Tile
    {
        private Texture2D _texture;
        private Vector2 _position;
        private int _tilenr;

        public Tile(Texture2D texture, Vector2 position, int tilenr)
        {
            this._texture = texture;
            this._position = position;
            this._tilenr = tilenr;
        }

        public Texture2D GetTexture()
        {
            return this._texture;
        }

        public void SetTexture(Texture2D texture)
        {
            this._texture = texture;
        }

        public Vector2 GetPosition()
        {
            return this._position;
        }

        public void SetPosition(Vector2 position)
        {
            this._position = position;
        }

        public int GetTileNr()
        {
            return this._tilenr;
        }

        public void SetTileNr(int tileNr) 
        {
            this._tilenr = tileNr;
        }
    }
}
