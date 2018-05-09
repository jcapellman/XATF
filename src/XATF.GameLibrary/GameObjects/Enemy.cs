using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

using XATF.GameLibrary.Data.Objects;
using XATF.GameLibrary.Enums;
using XATF.GameLibrary.Renderables.BaseObjects;
using Aircraft = XATF.GameLibrary.Data.Objects.Aircraft;

namespace XATF.GameLibrary.GameObjects
{
    public class Enemy : BaseGameObject<Renderables.BaseObjects.Aircraft, Aircraft>
    {
        public override void Initialize(Aircraft dataObject, ContentManager content)
        {
            Renderable = new Renderables.BaseObjects.Aircraft(dataObject.TextureName, Vector2.One, content);

            base.Initialize(dataObject, content);
        }

        public override void Move(MovementTypes movementType)
        {
            throw new System.NotImplementedException();
        }

        public override void Update(int x, int y)
        {
            
        }
    }
}