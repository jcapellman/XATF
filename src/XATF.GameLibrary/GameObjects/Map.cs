using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using XATF.GameLibrary.Renderables.BaseObjects;

namespace XATF.GameLibrary.GameObjects
{
    public class Map
    {
        private readonly List<MapTile> _mapTiles = new List<MapTile>();

        public void LoadMap(string name, ContentManager content)
        {
            for (var x = 0; x <= 3; x++)
            {
                for (var y = 0; y < 100; y++)
                {
                    var tile = new MapTile();

                    tile.Initialize("Water", new Vector2(x * 256, -y * 256), content);

                    _mapTiles.Add(tile);
                }
            }
        }

        public void Update()
        {
            foreach (var tile in _mapTiles)
            {
                tile.Update();
            }
        }

        public void Render(SpriteBatch spriteBatch)
        {
            foreach (var tile in _mapTiles)
            {
                tile.Render(spriteBatch);
            }
        }
    }
}