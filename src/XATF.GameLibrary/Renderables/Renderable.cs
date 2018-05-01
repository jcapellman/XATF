using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace XATF.GameLibrary.Renderables
{
    public abstract class Renderable
    {
        protected Texture2D Texture;
        protected Vector2 Position;

        protected abstract string FolderBase { get; }

        public void Initialize(string textureName, Vector2 position, ContentManager content)
        {
            Texture = content.Load<Texture2D>($"{FolderBase}\\{textureName}");
            Position = position;
        }

        public void Render(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, Color.Black);
        }
    }
}