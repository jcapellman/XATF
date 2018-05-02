using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using XATF.GameLibrary.Renderables.BaseObjects;

namespace XATF.GameLibrary.GameObjects
{
    public class Player
    {
        private readonly Aircraft _playerAircraft = new Aircraft();
        
        public void Initialize(string aircraftName, ContentManager content)
        {
            _playerAircraft.Initialize(aircraftName, Vector2.One, content);
        }

        public void Update(int x, int y)
        {
            _playerAircraft.Update(x, y);
        }

        public void Render(SpriteBatch spriteBatch)
        {
            _playerAircraft.Render(spriteBatch);
        }
    }
}