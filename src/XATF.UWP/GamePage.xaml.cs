using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using XATF.GameLibrary;

namespace XATF.UWP
{
    public sealed partial class GamePage : Page
    {
        private readonly MainGame _game;

		public GamePage()
        {
            InitializeComponent();
            
            _game = MonoGame.Framework.XamlGame<MainGame>.Create(string.Empty, Window.Current.CoreWindow, swapChainPanel);
        }
    }
}