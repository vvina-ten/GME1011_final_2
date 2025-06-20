using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace GME1011_final_2
{

   /* internal class Powerzombie : Zombie
    {
        private Texture2D _powertexture;

        public Powerzombie(Texture2D powertexture, int x, int y, float movespeed, int health) : base(powertexture, x, y, movespeed, 50)
        {
            _powertexture = powertexture;
        }

        public override void Draw(SpriteBatch spriteBatch, SpriteFont font)
        {
            if (_remove)
            {
                return;
            }

            if (_isalive)
            {
                spriteBatch.Begin();

                spriteBatch.Draw(_powertexture, _position, null, Color.White, 0f, Vector2.Zero, new Vector2(0.1f, 0.1f), 0, 0f);

                Vector2 healthloc = new Vector2(_position.X + 25, _position.Y - 22);
                spriteBatch.DrawString(font, "Big health: " + _health, healthloc, Color.Black);

                spriteBatch.End();

            }
        }
    }
   */
}














