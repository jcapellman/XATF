using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

using XATF.GameLibrary.Common;
using XATF.GameLibrary.Renderables.BaseObjects;

namespace XATF.GameLibrary.GameObjects
{
    public class Map : BaseGameObject<MapTile>
    {
        public override void Initialize(string objectName, ContentManager content, ObjectWrapper wrapper)
        {
            // TODO: Load actual map file from the objectName parameter
            for (var x = 0; x <= 3; x++)
            {
                for (var y = 0; y < 100; y++)
                {
                    Renderables.Add(new MapTile("Water", new Vector2(x * 256, -y * 256), content));
                }
            }
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