using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace XATF.GameLibrary.Renderables.BaseObjects
{
    public class Text : Renderable
    {
        private readonly SpriteFont _font;

        private readonly string _stringContent;

        protected override string FolderBase => "Fonts";
        
        public override void Render(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(_font, _stringContent, new Vector2(10, 20), Color.White);
        }

        public Text(string textureName, Vector2 position, ContentManager content) : base(textureName, position, content)
        {
            _font = content.Load<SpriteFont>("HUD");

            _stringContent = textureName;
        }
    }
}