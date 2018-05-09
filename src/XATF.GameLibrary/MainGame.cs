using Windows.UI.ViewManagement;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using XATF.GameLibrary.Common;
using XATF.GameLibrary.Data;
using XATF.GameLibrary.Scenes;

namespace XATF.GameLibrary
{
    public class MainGame : Game
    {
        GraphicsDeviceManager _graphics;
        SpriteBatch _spriteBatch;
        
        private BaseScene _scene;

        private Vector2 Resolution
        {
            get
            {
                var width = ApplicationView.GetForCurrentView().VisibleBounds.Width;
                var height = ApplicationView.GetForCurrentView().VisibleBounds.Height;

                return new Vector2((float) width, (float)height);
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

            IoC.Initialize(new SQLiteDAL(), Resolution);

            _scene = new GameScene();

            _scene.QuitGame += _scene_QuitGame;
            _scene.Initialize(Content, "E1M1");
        }

        private void _scene_QuitGame(object sender, System.EventArgs e)
        {
            Exit();
        }

        protected override void UnloadContent()
        {

        }
        
        protected override void Update(GameTime gameTime)
        {
           _scene.Update();

            base.Update(gameTime);
        }
        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            _spriteBatch.Begin();

            _scene.Render(_spriteBatch);
            
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}