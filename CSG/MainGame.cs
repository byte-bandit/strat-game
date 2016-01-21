// -----------------------------------------------------------------------------------------------------
// <copyright file="MainGame.cs" company="Knasl Games">
//   (c) Knasl Games
// </copyright>
// -----------------------------------------------------------------------------------------------------

namespace StratGame
{
    using Sharpex2D;
    using Sharpex2D.Audio.WaveOut;
    using Sharpex2D.GameService;
    using Sharpex2D.Rendering.DirectX11;
    using Sharpex2D.Rendering.GDI;
    using StratGame.Scenes;

    /// <summary>
    /// The main game.
    /// </summary>
    internal class MainGame : Game
    {
        /// <summary>
        /// The on initialize.
        /// </summary>
        /// <param name="launchParameters">
        /// The launch parameters.
        /// </param>
        /// <returns>
        /// The <see cref="EngineConfiguration"/>.
        /// </returns>
        public override EngineConfiguration OnInitialize(LaunchParameters launchParameters)
        {
            this.GameComponentManager.Add(this.SceneManager);
            return new EngineConfiguration(new DirectXRenderDevice() , new WaveOutInitializer());
        }

        /// <summary>
        /// The on load content.
        /// </summary>
        public override void OnLoadContent()
        {
            this.SceneManager.AddScene(new PrototypeScene());
            this.SceneManager.ActiveScene = this.SceneManager.Get<PrototypeScene>();
        }
    }
}