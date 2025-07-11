﻿using System.Collections.Generic;
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

        Zombie[] zombies;

        /*Zombie zombie1;
        Zombie zombie2;
        Zombie zombie3;
        Zombie zombie4;
        */

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

            zombies = new Zombie[4];

            zombies[0] = new Zombie(Content.Load<Texture2D>("zombie_2"), 1450, 50, 2f, 10);
            zombies[1] = new Zombie(Content.Load<Texture2D>("zombie_2"), 1650, 180, 2f, 10);
            zombies[2] = new Zombie(Content.Load<Texture2D>("zombie_2"), 1890, 310, 2f, 10);
            zombies[3] = new Zombie(Content.Load<Texture2D>("zombie_2"), 2230, 450, 2f, 10);

            /* zombie1 = new Zombie(Content.Load<Texture2D>("zombie_2"),1450,50,2f,10);
             zombie2 = new Zombie(Content.Load<Texture2D>("zombie_2"), 1850, 220, 2f, 10);
             zombie3 = new Zombie(Content.Load<Texture2D>("zombie_2"), 2120, 380, 2f, 10);
             zombie4 = new Zombie(Content.Load<Texture2D>("zombie_2"), 2520, 500, 2f, 10);
            */
            //   powerzombie = new Powerzombie(Content.Load<Texture2D>("zombie_3"), 1450, 100, 2f, 10);

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            for(int i = 0; i < zombies.Length; i++)
            {

                if (!zombies[i].IsAlive() || zombies[i].GetX() < -100)
                {

                    int yPosition = 150 + (i * 130);
                    int xPosition = 1450 + (i * 90);
                    zombies[i] = new Zombie(Content.Load<Texture2D>("zombie_2"), xPosition, yPosition, 2f, 10);
                }

                zombies[i].Update();


                if (zombies[i].HasCounted())
                {
                    _zombiecount++;
                }
            }

            // TODO: Add your update logic here

            /*
                        if (!zombie1.IsAlive() || zombie1.GetX() < -100)
                        {
                            zombie1 = new Zombie(Content.Load<Texture2D>("zombie_2"), 1450, 50, 2f, 10);
                        }
                        if (!zombie2.IsAlive() || zombie2.GetX() < -100)
                        {
                            zombie2 = new Zombie(Content.Load<Texture2D>("zombie_2"), 1850, 220, 2f, 10);
                        }
                        if (!zombie3.IsAlive() || zombie3.GetX() < -100)
                        {
                            zombie3 = new Zombie(Content.Load<Texture2D>("zombie_2"), 2120, 380, 2f, 10);
                        }
                        if (!zombie4.IsAlive() || zombie4.GetX() < -100)
                        {
                            zombie4 = new Zombie(Content.Load<Texture2D>("zombie_2"), 2520, 500, 2f, 10);
                        }


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

            /*
             * zombie1.Draw(_spriteBatch,_gamefont);
            zombie2.Draw(_spriteBatch, _gamefont);
            zombie3.Draw(_spriteBatch, _gamefont);
            zombie4.Draw(_spriteBatch, _gamefont);
            */

            for (int i = 0; i < zombies.Length; i++)
            {
                zombies[i].Draw(_spriteBatch, _gamefont);
            }

            // powerzombie.Draw(_spriteBatch,_gamefont);

            _spriteBatch.Begin();

            _spriteBatch.DrawString(_gamefont,"Now there are " + _zombiecount + "zombies!", new Vector2(10,450), Color.Red);

            

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
