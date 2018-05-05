using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace XATF.GameLibrary.Renderables.BaseObjects
{
    public abstract class Renderable
    {
        protected Texture2D Texture;
        protected Vector2 Position;

        protected abstract string FolderBase { get; }

        protected Renderable(string textureName, Vector2 position, ContentManager content)
        {
            Texture = content.Load<Texture2D>($"{FolderBase}\\{textureName}");
            Position = position;
        }

        public virtual void Render(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, Color.White);
        }

        public void Update(int x, int y)
        {
            Position.X += x;
            Position.Y += y;
        }
    }
}