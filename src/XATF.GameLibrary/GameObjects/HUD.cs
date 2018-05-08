using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using XATF.GameLibrary.Common;
using XATF.GameLibrary.Renderables.BaseObjects;

namespace XATF.GameLibrary.GameObjects
{
    public class HUD : BaseGameObject<Text>
    {
        private int _score;
        private int _health;

        public HUD()
        {
            _score = 0;
            _health = 100;
        }

        public override void Initialize(string objectName, ContentManager content, ObjectWrapper wrapper)
        {
            Renderables.Add(new Text(objectName, "HUD", new Vector2(10, 20), content));
            Renderables.Add(new Text(_score.ToString(), "HUD", new Vector2((wrapper.Resolution.width - _score.ToString().Length) / 2, 20), content));
        }

        public override void Update(int x, int y)
        {
            
        }
    }
}