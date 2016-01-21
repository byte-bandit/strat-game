// -----------------------------------------------------------------------------------------------------
// <copyright file="IntroScene.cs" company="Knasl Games">
//   (c) Knasl Games
// </copyright>
// -----------------------------------------------------------------------------------------------------

namespace StratGame.Scenes
{
    using System.Collections.Generic;
    using Sharpex2D;
    using Sharpex2D.Content;
    using Sharpex2D.Input;
    using Sharpex2D.Math;
    using Sharpex2D.Rendering;
    using Sharpex2D.Rendering.Scene;
    using StratGame.Drawing;

    /// <summary>
    /// The intro scene.
    /// </summary>
    internal class PrototypeScene : Scene
    {
        private Font font;

        private Texture2D grassTexture2D;

        private List<Tile> tiles;

        public override void Update(GameTime gameTime)
        {
            var input = SGL.Components.Get<InputManager>();

            var state = input.Keyboard.GetState();
        }

        public override void Render(RenderDevice renderer, GameTime gameTime)
        {
            renderer.GraphicsDevice.ClearColor = Color.Black;
            
            tiles.ForEach(x => x.Render(renderer, gameTime));

            //renderer.DrawTexture(grassTexture2D, new Vector2(20, 20), Color.White);
        }

        public override void Initialize()
        {
            
        }

        public override void LoadContent(ContentManager content)
        {
            grassTexture2D = content.Load<Texture2D>("tile_grass.png");

            tiles = new List<Tile>
                {
                    new Tile(0, 0, this.grassTexture2D),
                    new Tile(128, 128, this.grassTexture2D),
                    new Tile(128, 160, this.grassTexture2D),
                    new Tile(128, 192, this.grassTexture2D)
                };
        }
    }
}