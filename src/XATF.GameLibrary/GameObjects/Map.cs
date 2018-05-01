using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using XATF.GameLibrary.Renderables;

namespace XATF.GameLibrary.GameObjects
{
    public class Map
    {
        private readonly List<MapTile> _mapTiles = new List<MapTile>();

        public void LoadMap(string name, ContentManager content)
        {
            for (var x = 0; x < 100; x++)
            {
                for (var y = 0; y < 100; y++)
                {
                    var tile = new MapTile();

                    tile.Initialize("Water", new Vector2(x, y), content);

                    _mapTiles.Add(tile);
                }
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