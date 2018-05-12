using System;

using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using XATF.GameLibrary.Common;
using XATF.GameLibrary.Data.Objects;
using XATF.GameLibrary.Enums;
using XATF.GameLibrary.GameObjects;
using HUD = XATF.GameLibrary.GameObjects.HUD;

namespace XATF.GameLibrary.Scenes
{
    public class GameScene : BaseScene
    {
        private Map map = new Map();
        private Player player = new Player();
        private HUD hud = new HUD();

        public override void Initialize(ContentManager content, string argument = null)
        {
            var levelObject = IoC.DataAccess.GetOne<Level>(a => a.Name == argument);

            if (levelObject == null)
            {
                throw new Exception($"Could not find level {argument}");
            }

            var hudObject = new Data.Objects.HUD
            {
                LevelName = levelObject.Name,
                Score = 0,
                Lives = 3
            };

            hud.Initialize(hudObject, content);

            map.Initialize(levelObject, content);

            var playerAircraft = IoC.DataAccess.GetOne<Aircraft>(a => a.ID == levelObject.PlayerAircraftID);

            if (playerAircraft == null)
            {
                throw new Exception($"Could not find aircraft {levelObject.PlayerAircraftID}");
            }

            player.Initialize(playerAircraft, content);
        }

        public override void Update()
        {
            map.Update(0, 0);
            
            var keys = GetKeyDown();

            foreach (var key in keys)
            {
                switch (key)
                {
                    case Keys.Escape:
                        OnQuitGame();
                        break;
                    case Keys.Up:
                        player.Move(MovementTypes.UP);
                        break;
                    case Keys.Down:
                        player.Move(MovementTypes.DOWN);
                        break;
                    case Keys.Left:
                        player.Move(MovementTypes.LEFT);
                        break;
                    case Keys.Right:
                        player.Move(MovementTypes.RIGHT);
                        break;
                }
            }
        }

        public override void Render(SpriteBatch spriteBatch)
        {
            map.Render(spriteBatch);

            player.Render(spriteBatch);

            hud.Render(spriteBatch);
        }
    }
}