using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace GME1011_final_2
{
    internal class Zombie
    {
        private Texture2D _zombie;
        private Vector2 _position;

        private float _scale;
        private float _movespeed;


        public Zombie(Texture2D zombie, int x, int y)
        {
            _zombie = zombie;
            _position = new Vector2(x,y);
            _movespeed = 5f;

        }

        public void Update()
        {
            _position.X -= _movespeed;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
   
            spriteBatch.Begin();

            spriteBatch.Draw(_zombie, _position, null, Color.White, 0f, Vector2.Zero, new Vector2(0.1f, 0.1f), SpriteEffects.None, 0f);

            spriteBatch.End();


        }


        public Rectangle GetBounds()
        { 
            return new Rectangle((int)_position.X,(int)_position.Y,_zombie.Width, (int)_zombie.Height);
        }











    }
}
