using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

using XATF.GameLibrary.Data.Objects;
using XATF.GameLibrary.Enums;
using XATF.GameLibrary.Renderables.BaseObjects;

namespace XATF.GameLibrary.GameObjects
{
    public class Map : BaseGameObject<MapTile, Level>
    {
        public override void Initialize(Level dataObject, ContentManager content)
        {
            // TODO: Load actual map file from the objectName parameter
            for (var x = 0; x <= 3; x++)
            {
                for (var y = 0; y < 100; y++)
                {
                    Renderables.Add(new MapTile("Water", new Vector2(x * 256, -y * 256), content));
                }
            }

            base.Initialize(dataObject, content);
        }

        public override void Move(MovementTypes movementType)
        {
            throw new System.NotImplementedException();
        }

        public override void Update(int x, int y)
        {
            foreach (var tile in Renderables)
            {
                tile.Update(0, 2);
            }
        }
    }
}