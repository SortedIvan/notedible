using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace NotEdible
{
    public static class Globals
    {
        public static float TotalSeconds { get; set; }
        public static SpriteBatch SpriteBatch { get; set; }
        public static GraphicsDevice graphicsDevice { get; set; }

        public static void Update(GameTime gameTime)
        {
            TotalSeconds = (float)gameTime.ElapsedGameTime.TotalSeconds;
        }

    }
}
