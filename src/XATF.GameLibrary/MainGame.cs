using Windows.UI.ViewManagement;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using XATF.GameLibrary.Common;
using XATF.GameLibrary.Scenes;

namespace XATF.GameLibrary
{
    public class MainGame : Game
    {
        GraphicsDeviceManager _graphics;
        SpriteBatch _spriteBatch;

        private BaseScene _scene;

        private (float width, float height) Resolution
        {
            get
            {
                var width = ApplicationView.GetForCurrentView().VisibleBounds.Width;
                var height = ApplicationView.GetForCurrentView().VisibleBounds.Height;

                return ((float width, float height)) (width, height);
            }
        }

        private ObjectWrapper Wrapper => new ObjectWrapper
        {
            Resolution = Resolution
        };

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

            _scene = new GameScene();

            _scene.QuitGame += _scene_QuitGame;
            _scene.Initialize(Content, Wrapper, "E1M1");
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
           _scene.Update(Resolution);

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