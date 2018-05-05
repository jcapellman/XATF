using System.Collections.Generic;

using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using XATF.GameLibrary.Renderables.BaseObjects;

namespace XATF.GameLibrary.GameObjects
{
    public abstract class BaseGameObject<T> where T : Renderable
    {
        protected T Renderable;
        protected List<T> Renderables;

        protected BaseGameObject()
        {
            Renderables = new List<T>();
        }

        public abstract void Initialize(string objectName, ContentManager content);

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