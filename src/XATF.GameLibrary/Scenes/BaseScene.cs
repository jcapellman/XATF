using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace XATF.GameLibrary.Scenes
{
    public abstract class BaseScene
    {
        public abstract void Initialize(ContentManager content, string argument = null);

        public abstract void Update((float width, float height) resolution);

        public abstract void Render(SpriteBatch spriteBatch, (float width, float height) resolution);
    }
}