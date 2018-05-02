using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using XATF.GameLibrary.GameObjects;
using XATF.GameLibrary.Renderables.BaseObjects;

namespace XATF.GameLibrary
{
    public class MainGame : Game
    {
        GraphicsDeviceManager _graphics;
        SpriteBatch _spriteBatch;

        private Aircraft aircraftPlayer = new Aircraft();
        private Map map = new Map();

        public MainGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
        
        protected override void Initialize()
        {
            base.Initialize();
        }
        
        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            map.LoadMap("E1M1", Content);

            aircraftPlayer.Initialize("F25", Vector2.One, Content);
        }
        
        protected override void UnloadContent()
        {

        }
        
        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            _spriteBatch.Begin();

            map.Render(_spriteBatch);

            aircraftPlayer.Render(_spriteBatch);
            
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}