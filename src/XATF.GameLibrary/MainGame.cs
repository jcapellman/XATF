using System.Text;
using Windows.UI.ViewManagement;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using XATF.GameLibrary.GameObjects;
using XATF.GameLibrary.Renderables.BaseObjects;

namespace XATF.GameLibrary
{
    public class MainGame : Game
    {
        GraphicsDeviceManager _graphics;
        SpriteBatch _spriteBatch;
        
        private Map map = new Map();
        private Player player = new Player();
        private HUD hud = new HUD();

        private (float width, float height) Resolution
        {
            get
            {
                var width = ApplicationView.GetForCurrentView().VisibleBounds.Width;
                var height = ApplicationView.GetForCurrentView().VisibleBounds.Height;

                return ((float width, float height)) (width, height);
            }
        }

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

            hud.Initialize("E1M1", Content);

            map.LoadMap("E1M1", Content);

            player.Initialize("F25", Content);
        }
        
        protected override void UnloadContent()
        {

        }
        
        protected override void Update(GameTime gameTime)
        {
            map.Update();

            var state = Keyboard.GetState();
            
            if (state.IsKeyDown(Keys.Escape))
            {
                Exit();
            }

            var playerX = 0;
            var playerY = 0;

            if (state.IsKeyDown(Keys.Right))
            {
                playerX += 10;
            }

            if (state.IsKeyDown(Keys.Left))
            {
                playerX -= 10;
            }

            if (state.IsKeyDown(Keys.Up))
            {
                playerY -= 10;
            }
            
            if (state.IsKeyDown(Keys.Down))
            {
                playerY += 10;
            }

            player.Update(playerX, playerY, Resolution);

            base.Update(gameTime);
        }
        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            _spriteBatch.Begin();

            map.Render(_spriteBatch);

            player.Render(_spriteBatch);
            
            hud.Render(_spriteBatch, Resolution);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}