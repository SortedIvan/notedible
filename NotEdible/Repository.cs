using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.Diagnostics;
using NotEdible.exceptions;

namespace NotEdible
{
    /// <summary>
    /// Repository for caching loaded textures
    /// 
    /// REMARK: This class is no longer as necessary, as through research I have found that
    /// MonoGame's ContentManager class does this automatically for me.
    /// 
    /// 
    /// </summary>
    public class Repository
    {
        // Loaded textures holding all of the assets within the game
        private Dictionary<string, Texture2D> loadedTextures;
        // Loaded fonts
        private Dictionary<string, SpriteFont> loadedFonts;
        private ContentManager content;
        public Repository(ContentManager content)
        {
            this.content = content;
            this.loadedTextures = new Dictionary<string, Texture2D>();
            this.loadedFonts = new Dictionary<string, SpriteFont>();
        }


        #region Texture Methods
        public Texture2D LoadTexture(string textureName)
        {
            return content.Load<Texture2D>(textureName);
        }

        public void LoadAndSaveTexture(string textureName)
        {
            if (textureName.Equals(null))
            {
                throw new TextureException($"{textureName} is not valid. Please provide valid values.");
            }
            Debug.WriteLine("Texture has been saved");
            loadedTextures.Add(textureName, LoadTexture(textureName));
        }

        public Texture2D GetTexture(string textureName)
        {
            Texture2D texture;
            bool hasTexture = loadedTextures.TryGetValue(textureName, out texture);
            if (hasTexture)
            {
                return texture;
            }
            Debug.WriteLine($"{texture.ToString()} + {textureName}");
            throw new TextureException($"Texture with name: {textureName} has not been found");
        }
        #endregion

        #region Font Methods
        public SpriteFont LoadFont(string fontName)
        {
            return this.content.Load<SpriteFont>(fontName);
        }

        public void LoadAndSaveFont(string fontName)
        {
            if (fontName.Equals(null))
            {
                throw new FontExceptions($"{fontName} was null. Please provide a valid value.");
            }
            this.loadedFonts.Add(fontName, LoadFont(fontName));
        }

        public SpriteFont GetFont(string fontName)
        {
            SpriteFont spriteFont;
            bool fontExists = loadedFonts.TryGetValue(fontName, out spriteFont);
            if (fontExists)
            {
                return spriteFont;
            }
            throw new FontExceptions($"Font with {fontName} doesn't exist. Please enter valid values");
        }
        #endregion

    }
}
