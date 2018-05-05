using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using XATF.GameLibrary.Renderables.BaseObjects;

namespace XATF.GameLibrary.GameObjects
{
    public class Player : BaseGameObject<Aircraft>
    {
        public override void Initialize(string objectName, ContentManager content)
        {
            Renderable = new Aircraft(objectName, Vector2.One, content);
        }

        public override void Update(int x, int y)
        {
            Renderable?.Update(x, y);
        }
    }
}