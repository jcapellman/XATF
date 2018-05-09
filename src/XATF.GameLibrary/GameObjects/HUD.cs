using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

using XATF.GameLibrary.Common;
using XATF.GameLibrary.Data.Objects;
using XATF.GameLibrary.Enums;
using XATF.GameLibrary.Renderables.BaseObjects;

namespace XATF.GameLibrary.GameObjects
{
    public class HUD : BaseGameObject<Text, Data.Objects.HUD>
    {
        private int _score;
        private int _health;

        public HUD()
        {
            _score = 0;
            _health = 100;
        }

        public override void Initialize(Data.Objects.HUD dataObject, ContentManager content)
        {
            Renderables.Add(new Text(dataObject.LevelName, "HUD", new Vector2(10, 20), content));
            Renderables.Add(new Text(dataObject.Score.ToString(), "HUD", new Vector2((IoC.Resolution.X - _score.ToString().Length) / 2, 20), content));

            base.Initialize(dataObject, content);
        }

        public override void Move(MovementTypes movementType)
        {
            throw new System.NotImplementedException();
        }

        public override void Update(int x, int y)
        {
            
        }
    }
}