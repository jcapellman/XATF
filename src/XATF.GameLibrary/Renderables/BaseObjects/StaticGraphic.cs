using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

using XATF.GameLibrary.Enums;

namespace XATF.GameLibrary.Renderables.BaseObjects
{
    public class StaticGraphic : Renderable
    {
        public StaticGraphic(string textureName, Vector2 position, ContentManager content) : base(textureName, RenderableBaseType.TEXTURE, position, content)
        {
        }

        protected override string FolderBase => "Static";
    }
}