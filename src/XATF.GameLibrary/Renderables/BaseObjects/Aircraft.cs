using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace XATF.GameLibrary.Renderables.BaseObjects
{
    public class Aircraft : Renderable
    {
        protected override string FolderBase => "Aircraft";

        public Aircraft(string textureName, Vector2 position, ContentManager content) : base(textureName, position, content)
        {
        }
    }
}