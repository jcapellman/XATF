using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using XATF.GameLibrary.Renderables.BaseObjects;

namespace XATF.GameLibrary.Scenes
{
    public class MainMenuScene : BaseScene
    {
        private StaticGraphic background;
        private StaticGraphic selector;

        public override void Initialize(ContentManager content, string argument = null)
        {
            background = new StaticGraphic("MainMenuBG", Vector2.One, content);
            selector = new StaticGraphic("Selector", Vector2.One, content);
        }

        public override void Update()
        {
            var keys = GetKeyDown();

            foreach (var key in keys)
            {
                switch (key)
                {
                    case Keys.Escape:
                        OnQuitGame();
                        break;
                    case Keys.Up:
                    case Keys.Down:
                    case Keys.Left:
                    case Keys.Right:
                        // Handle selector movement
                        break;                    
                }
            }
        }

        public override void Render(SpriteBatch spriteBatch)
        {
            
        }
    }
}
