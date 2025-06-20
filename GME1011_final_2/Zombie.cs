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
        private float _cooldowntimer;
        private bool _remove;

        public Zombie(Texture2D zombie, int x, int y,float movespeed,int health)
        {
            _zombie = zombie;
            _position = new Vector2(x,y);
            _movespeed = movespeed;
            _isalive = true;
            _health = health;
            _cooldowntimer = 0;
            _remove = false;
        }

        public void Update()
        {
            if (_isalive)
            {
                _position.X -= _movespeed;

                if (_cooldowntimer >= 0)
                { 
                    _cooldowntimer--;
                }

                MouseState currentMouseState = Mouse.GetState();


                if (currentMouseState.LeftButton == ButtonState.Pressed && _cooldowntimer <= 0)
                {
                    if (GetBounds().Contains(currentMouseState.Position))
                    {
                        _health -= 1;
                        _cooldowntimer = 20f;
                    }

                    if (_health <= 0)
                    { 
                        _isalive = false;
                        _remove = true;
                    }
                }
            }
        }

        

        public void Draw(SpriteBatch spriteBatch,SpriteFont font)
        {
            if (_remove)
            {
                return;
            }

            if (_isalive)
            {
                spriteBatch.Begin();

                spriteBatch.Draw(_zombie, _position, null, Color.White, 0f, Vector2.Zero, new Vector2(0.1f, 0.1f), 0, 0f);

                Vector2 healthloc = new Vector2(_position.X + 25, _position.Y - 22);
                spriteBatch.DrawString(font, "health: " + _health, healthloc, Color.BurlyWood);

                spriteBatch.End();

            }
        }


        public Rectangle GetBounds()
        { 
            return new Rectangle((int)_position.X,(int)_position.Y,(int)(_zombie.Width*0.1f), (int)(_zombie.Height*0.1f));
        }

        public bool IsAlive()
        {
            return _isalive;
        }

        public float GetX()
        { 
            return _position.X; 
        }

        public bool HasCounted()
        {
            return _position.X <= 1400 && _position.X >= 1400;
        }



    }
}
