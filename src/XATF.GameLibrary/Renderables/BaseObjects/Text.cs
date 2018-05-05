using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using XATF.GameLibrary.Enums;

namespace XATF.GameLibrary.Renderables.BaseObjects
{
    public class Text : Renderable
    {
        private readonly string _stringContent;

        protected override string FolderBase => "Fonts";
        
        public override void Render(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(Font, _stringContent, new Vector2(10, 20), Color.White);
        }

        public Text(string stringContent, string fontName, Vector2 position, ContentManager content) : base(fontName, RenderableBaseType.FONT, position, content)
        {
            _stringContent = stringContent;
        }
    }
}