using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GME1011_final_2
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private SpriteFont _gamefont;

        Zombie zombie1;
        Zombie zombie2;
        Zombie zombie3;
        Zombie zombie4;

        //  Powerzombie powerzombie;
        private int _zombiecount;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            _graphics.PreferredBackBufferWidth = 1500;
            _graphics.PreferredBackBufferHeight = 700;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            
            _zombiecount = 0;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            _gamefont = Content.Load<SpriteFont>("GameFont");

            zombie1 = new Zombie(Content.Load<Texture2D>("zombie_2"),1450,50,2f,10);
            zombie2 = new Zombie(Content.Load<Texture2D>("zombie_2"), 1550, 180, 2f, 10);
            zombie3 = new Zombie(Content.Load<Texture2D>("zombie_2"), 1620, 310, 2f, 10);
            zombie4 = new Zombie(Content.Load<Texture2D>("zombie_2"), 1720, 450, 2f, 10);
            //   powerzombie = new Powerzombie(Content.Load<Texture2D>("zombie_3"), 1450, 100, 2f, 10);

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here


            if (zombie1.IsAlive())
            { 
                zombie1.Update();

                if (zombie1.HasCounted())
                { 
                    _zombiecount++;
                }
            }

            if (zombie2.IsAlive())
            {
                zombie2.Update();

                if (zombie2.HasCounted())
                {
                    _zombiecount++;
                }
            }
            if (zombie3.IsAlive())
            {
                zombie3.Update();

                if (zombie3.HasCounted())
                {
                    _zombiecount++;
                }
            }
            if (zombie4.IsAlive())
            {
                zombie4.Update();

                if (zombie4.HasCounted())
                {
                    _zombiecount++;
                }
            }

            /*  if (powerzombie.IsAlive())
              {
                  powerzombie.Update();

                  if (powerzombie.HasCounted())
                  {
                      _zombiecount++;
                  }
              }
            */

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.ForestGreen);

            // TODO: Add your drawing code here

            zombie1.Draw(_spriteBatch,_gamefont);
            zombie2.Draw(_spriteBatch, _gamefont);
            zombie3.Draw(_spriteBatch, _gamefont);
            zombie4.Draw(_spriteBatch, _gamefont);

            // powerzombie.Draw(_spriteBatch,_gamefont);

            _spriteBatch.Begin();

            _spriteBatch.DrawString(_gamefont,"Now there are " + _zombiecount + "zombies!", new Vector2(10,450), Color.Red);

            

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
