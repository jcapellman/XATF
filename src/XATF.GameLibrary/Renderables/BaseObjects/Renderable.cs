using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using XATF.GameLibrary.Enums;

namespace XATF.GameLibrary.Renderables.BaseObjects
{
    public abstract class Renderable
    {
        protected Texture2D Texture;
        protected SpriteFont Font;
        protected Vector2 Position;

        protected abstract string FolderBase { get; }

        protected Renderable(string textureName, RenderableBaseType renderableBaseType, Vector2 position, ContentManager content)
        {
            switch (renderableBaseType)
            {
                case RenderableBaseType.TEXTURE:
                    Texture = content.Load<Texture2D>($"{FolderBase}\\{textureName}");
                    break;
                case RenderableBaseType.FONT:
                    Font = content.Load<SpriteFont>(textureName);
                    break;
            }

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