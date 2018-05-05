using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using XATF.GameLibrary.GameObjects;

namespace XATF.GameLibrary.Scenes
{
    public class GameScene : BaseScene
    {
        private Map map = new Map();
        private Player player = new Player();
        private HUD hud = new HUD();

        public override void Initialize(ContentManager content, string argument = null)
        {
            hud.Initialize(argument, content);

            map.Initialize(argument, content);

            player.Initialize("F25", content);
        }

        public override void Update((float width, float height) resolution)
        {
            map.Update(0, 0);

            var state = Keyboard.GetState();

            if (state.IsKeyDown(Keys.Escape))
            {
                return;
            }

            var playerX = 0;
            var playerY = 0;

            if (state.IsKeyDown(Keys.Right))
            {
                playerX += 10;
            }

            if (state.IsKeyDown(Keys.Left))
            {
                playerX -= 10;
            }

            if (state.IsKeyDown(Keys.Up))
            {
                playerY -= 10;
            }

            if (state.IsKeyDown(Keys.Down))
            {
                playerY += 10;
            }

            player.Update(playerX, playerY);

        }

        public override void Render(SpriteBatch spriteBatch, (float width, float height) resolution)
        {
            map.Render(spriteBatch);

            player.Render(spriteBatch);

            hud.Render(spriteBatch);
        }
    }
}