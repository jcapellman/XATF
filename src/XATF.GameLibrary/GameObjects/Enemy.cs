using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

using XATF.GameLibrary.Renderables.BaseObjects;

namespace XATF.GameLibrary.GameObjects
{
    public class Enemy : BaseGameObject<Aircraft>
    {
        public override void Initialize(string objectName, ContentManager content)
        {
            Renderable = new Aircraft(objectName, Vector2.One, content);
        }

        public override void Update(int x, int y)
        {
            
        }
    }
}