using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

using XATF.GameLibrary.Enums;

namespace XATF.GameLibrary.Renderables.BaseObjects
{
    public class Aircraft : Renderable
    {
        protected override string FolderBase => "Aircraft";

        public Aircraft(string textureName, Vector2 position, ContentManager content) : base(textureName, RenderableBaseType.TEXTURE, position, content)
        {
        }
    }
}