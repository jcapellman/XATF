using System;

using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace XATF.GameLibrary.Scenes
{
    public abstract class BaseScene
    {
        public abstract void Initialize(ContentManager content, string argument = null);

        public abstract void Update();

        public abstract void Render(SpriteBatch spriteBatch);

        protected Keys[] GetKeyDown()
        {
            var state = Keyboard.GetState();

            return state.GetPressedKeys();
        }

        public event EventHandler QuitGame;

        public void OnQuitGame()
        {
            QuitGame?.Invoke(null, null);
        }
    }
}