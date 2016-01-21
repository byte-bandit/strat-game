// -----------------------------------------------------------------------------------------------------
// <copyright file="Tile.cs" company="Knasl Games">
//   (c) Knasl Games
// </copyright>
// -----------------------------------------------------------------------------------------------------

namespace StratGame.Drawing
{
    using Sharpex2D;
    using Sharpex2D.Math;
    using Sharpex2D.Rendering;

    /// <summary>
    /// The tile.
    /// </summary>
    internal class Tile : IDrawable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tile"/> class.
        /// </summary>
        /// <param name="location">
        /// The location.
        /// </param>
        /// <param name="texture2D">
        /// The texture 2 d.
        /// </param>
        public Tile(Vector2 location, Texture2D texture2D)
        {
            this.Location = location;
            this.Texture2D = texture2D;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tile"/> class.
        /// </summary>
        /// <param name="x">
        /// The x.
        /// </param>
        /// <param name="y">
        /// The y.
        /// </param>
        /// <param name="texture2D">
        /// The texture 2 d.
        /// </param>
        public Tile(int x, int y, Texture2D texture2D)
            : this(new Vector2(x, y), texture2D)
        {
        }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        public Vector2 Location { get; set; }

        /// <summary>
        /// Gets or sets the texture 2 d.
        /// </summary>
        public Texture2D Texture2D { get; set; }

        /// <summary>
        /// The render.
        /// </summary>
        /// <param name="renderer">
        /// The renderer.
        /// </param>
        /// <param name="gameTime">
        /// The game time.
        /// </param>
        public void Render(RenderDevice renderer, GameTime gameTime)
        {
            renderer.DrawTexture(this.Texture2D, this.Location, Color.White);
        }
    }
}