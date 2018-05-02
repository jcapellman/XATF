using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace XATF.GameLibrary.GameObjects
{
    public class HUD
    {
        private int _score;
        private int _health;
        private string _levelName;

        private SpriteFont _font;

        public void Initialize(string levelName, ContentManager content)
        {
            _font = content.Load<SpriteFont>("HUD");
            _levelName = levelName;
        }

        public void Render(SpriteBatch spriteBatch, (float width, float height) resolution)
        {
            var scoreString = _font.MeasureString(_score.ToString());

            spriteBatch.DrawString(_font, _score.ToString(),
                new Vector2((resolution.width - scoreString.Length()) / 2, 20), Color.White);

            spriteBatch.DrawString(_font, _levelName, new Vector2(10, 20), Color.White);
        }
    }
}