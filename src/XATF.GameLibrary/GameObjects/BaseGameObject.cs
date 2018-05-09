using System.Collections.Generic;

using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using XATF.GameLibrary.Data.Objects;
using XATF.GameLibrary.Renderables.BaseObjects;

namespace XATF.GameLibrary.GameObjects
{
    public abstract class BaseGameObject<T, K> where T : Renderable where K : BaseDO
    {
        protected T Renderable;
        protected List<T> Renderables;
        protected BaseDO dataObject;

        protected BaseGameObject()
        {
            Renderables = new List<T>();
        }

        public virtual void Initialize(K dataObject, ContentManager content)
        {
            this.dataObject = dataObject;
        }

        public abstract void Move(Enums.MovementTypes movementType);

        public abstract void Update(int x, int y);

        public void Render(SpriteBatch spriteBatch)
        {
            Renderable?.Render(spriteBatch);
            
            foreach (var renderable in Renderables)
            {
                renderable.Render(spriteBatch);
            }
        }
    }
}