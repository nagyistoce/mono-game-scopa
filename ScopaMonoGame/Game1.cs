#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
#endregion

namespace ScopaMonoGame
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D back;

        Texture2D hand1_1;
        Texture2D hand1_2;
        Texture2D hand1_3;

        Texture2D hand2_1;
        Texture2D hand2_2;
        Texture2D hand2_3;

        Texture2D com1;
        Texture2D com2;
        Texture2D com3;
        Texture2D com4;


        public Game1()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = 600;
            graphics.PreferredBackBufferWidth = 1200;
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            back = Content.Load<Texture2D>("table");
            hand1_1 = Content.Load<Texture2D>("AssoC");
            hand1_2 = Content.Load<Texture2D>("DueC");
            hand1_3 = Content.Load<Texture2D>("NoveC");

            hand2_1 = Content.Load<Texture2D>("OttoD");
            hand2_2 = Content.Load<Texture2D>("QuattroC");
            hand2_3 = Content.Load<Texture2D>("SeiD");

            com1 = Content.Load<Texture2D>("SetteC");
            com2 = Content.Load<Texture2D>("SetteD");
            com3 = Content.Load<Texture2D>("TreC");
            com4 = Content.Load<Texture2D>("OttoC");
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            spriteBatch.Draw(back, Vector2.Zero, Color.White);
            spriteBatch.Draw(hand1_1, new Vector2((graphics.PreferredBackBufferWidth - 35) / 2 - 100, 20), null, Color.White, 0.0f, Vector2.Zero, 0.5f, SpriteEffects.None, 0.1f);
            spriteBatch.Draw(hand1_2, new Vector2((graphics.PreferredBackBufferWidth - 35) / 2, 20), null, Color.White, 0.0f, Vector2.Zero, 0.5f, SpriteEffects.None, 0.1f);
            spriteBatch.Draw(hand1_3, new Vector2((graphics.PreferredBackBufferWidth - 35) / 2 + 100, 20), null, Color.White, 0.0f, Vector2.Zero, 0.5f, SpriteEffects.None, 0.1f);
            spriteBatch.Draw(hand2_1, new Vector2((graphics.PreferredBackBufferWidth - 35) / 2 - 100, graphics.PreferredBackBufferHeight - 140), null, Color.White, 0.0f, Vector2.Zero, 0.5f, SpriteEffects.None, 0.1f);
            spriteBatch.Draw(hand2_2, new Vector2((graphics.PreferredBackBufferWidth - 35) / 2, graphics.PreferredBackBufferHeight - 140), null, Color.White, 0.0f, Vector2.Zero, 0.5f, SpriteEffects.None, 0.1f);
            spriteBatch.Draw(hand2_3, new Vector2((graphics.PreferredBackBufferWidth - 35) / 2 + 100, graphics.PreferredBackBufferHeight - 140), null, Color.White, 0.0f, Vector2.Zero, 0.5f, SpriteEffects.None, 0.1f);

            spriteBatch.Draw(com1, new Vector2((graphics.PreferredBackBufferWidth - 35) / 2 - 300, graphics.PreferredBackBufferHeight / 2 - 60), null, Color.White, 0.0f, Vector2.Zero, 0.5f, SpriteEffects.None, 0.1f);
            spriteBatch.Draw(com2, new Vector2((graphics.PreferredBackBufferWidth - 35) / 2 - 200, graphics.PreferredBackBufferHeight / 2 - 60), null, Color.White, 0.0f, Vector2.Zero, 0.5f, SpriteEffects.None, 0.1f);
            spriteBatch.Draw(com3, new Vector2((graphics.PreferredBackBufferWidth - 35) / 2 + 200, graphics.PreferredBackBufferHeight / 2 - 60), null, Color.White, 0.0f, Vector2.Zero, 0.5f, SpriteEffects.None, 0.1f);
            spriteBatch.Draw(com4, new Vector2((graphics.PreferredBackBufferWidth - 35) / 2 + 300, graphics.PreferredBackBufferHeight / 2 - 60), null, Color.White, 0.0f, Vector2.Zero, 0.5f, SpriteEffects.None, 0.1f);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
