using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using XATF.GameLibrary.Renderables.BaseObjects;

namespace XATF.GameLibrary.GameObjects
{
    public class Map
    {
        private List<Aircraft> _enemies = new List<Aircraft>();
        private readonly List<MapTile> _mapTiles = new List<MapTile>();

        public void LoadMap(string name, ContentManager content)
        {
            var aircraft = new Aircraft();

            aircraft.Initialize("Mig51", new Vector2(30, -10), content);

            _enemies.Add(aircraft);
            _enemies.Add(aircraft);

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
                tile.Update(0, 2);
            }

            foreach (var enemy in _enemies)
            {
                enemy.Update(0, 3);
            }
        }

        public void Render(SpriteBatch spriteBatch)
        {
            foreach (var tile in _mapTiles)
            {
                tile.Render(spriteBatch);
            }

            foreach (var enemy in _enemies)
            {
                enemy.Render(spriteBatch);
            }
        }
    }
}