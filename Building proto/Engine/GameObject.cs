using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Engine
{
    internal abstract class GameObject
    {
        public Vector2 Position { get; set; }
        public Vector2 Direction { get; set; }

        public virtual void Update(GameTime gameTime) { }
        //public virtual void HandleInput(InputHelper inputHelper) { }
        public virtual void Draw(SpriteBatch spriteBatch, GameTime gameTime) { }
    }
}