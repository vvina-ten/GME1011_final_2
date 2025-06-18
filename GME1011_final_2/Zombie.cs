using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace GME1011_final_2
{
    internal class Zombie
    {
        private Texture2D _zombie;
        private Vector2 _position;

        private float _movespeed;
        private bool _isalive;
        private int _health;

        public Zombie(Texture2D zombie, int x, int y,float movespeed,int health)
        {
            _zombie = zombie;
            _position = new Vector2(x,y);
            _movespeed = movespeed;
            _isalive = true;
            _health = health;
        }

        public void Update()
        {
            if (_isalive)
            {
                _position.X -= _movespeed;
            }
            
        }

        
        public void Draw(SpriteBatch spriteBatch,SpriteFont font)
        {
   
            spriteBatch.Begin();

            spriteBatch.Draw(_zombie, _position, null, Color.White, 0f, Vector2.Zero, new Vector2(0.1f, 0.1f), 0, 0f);

            Vector2 healthloc = new Vector2(_position.X + 25, _position.Y - 22);
            spriteBatch.DrawString(font,"health: " + _health, healthloc,Color.BurlyWood);

            spriteBatch.End();


        }


        public Rectangle GetBounds()
        { 
            return new Rectangle((int)_position.X,(int)_position.Y,(int)(_zombie.Width*0.1f), (int)(_zombie.Height*0.1f));
        }











    }
}
