using _321_Lab05_3;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace TheMuted.Sprite
{
    internal class Dennie
    {

        private AnimatedTexture dennie;

        private const float Rotation = 0;
        private const float Scale = 1.0f;
        private const float Depth = 0.5f;

        Vector2 denniepos = new Vector2(25, 25);

        private const int Frames = 4;
        private const int FramesPerSec = 6;
        private const int FramesRow = 8;

        //private bool stop = true;



        internal void LoadContent(ContentManager content)
        {
            dennie = new AnimatedTexture(Vector2.Zero, Rotation, Scale, Depth);
            dennie.Load(content, "Sheet", Frames, FramesRow, FramesPerSec);
        }

        int row = 1;
        internal void Update(GameTime gameTime)
        {

            float elapsed = (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                denniepos.Y -= 4;
                row = 4;
             
            }

            else if(Keyboard.GetState().IsKeyUp(Keys.W) && row == 4)
            {
                row = 8;
            }

            else if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                denniepos.Y += 4;
                row = 1;
      

            }

            else if (Keyboard.GetState().IsKeyUp(Keys.S) && row == 1)
            {
                row = 5;
            }

            else if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
               
                denniepos.X -= 4;
                row = 2;
             

            }

            else if (Keyboard.GetState().IsKeyUp(Keys.A) && row == 2)
            {
                row = 6;
            }

            else if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
               
                denniepos.X += 4;
                row = 3;
                

            }
            else if (Keyboard.GetState().IsKeyUp(Keys.W) && row == 3)
            {
                row = 7;
            }

            dennie.UpdateFrame(elapsed);



        }
        internal void Draw(SpriteBatch spriteBatch)
        {
            dennie.DrawFrame(spriteBatch, denniepos, row);

        }

    }
}