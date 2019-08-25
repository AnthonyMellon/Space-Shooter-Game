//A player object. Keeps track of the sprite image and the postion.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroids
{
    public class Player
    {
        private PictureBox playerSprite;

        private int spriteSizeX;
        private int spriteSizeY;
        private int spriteLeft;
        private int spriteTop;
        private int playerRotation;

        public Player(int spriteSizeX, int spriteSizeY, int spriteLeft, int spriteTop) //Constructor
        {
            this.spriteSizeX = spriteSizeX;
            this.spriteSizeY = spriteSizeY;

            this.spriteTop = spriteTop;
            this.spriteLeft = spriteLeft;
        }

        public PictureBox newSprite(GroupBox gameBox, int index) //Make a new sprite for the player.
        {
            int left = spriteLeft;
            int top = spriteTop;

            playerSprite = new PictureBox
            {
                Left = left,
                Top = top,

                Parent = gameBox,
                Size = new System.Drawing.Size(spriteSizeX, spriteSizeY),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Properties.Resources.ShipTemp,   
                Name = "Player"
            };

            return playerSprite;
        }

        public void MovePlayer(int velHorizontal, int velVertical) //Changes the players position
        {
            const int playerSpeed = 10;

            playerSprite.Top -= (velVertical * playerSpeed);
            playerSprite.Left -= (velHorizontal * playerSpeed);

            //switch (key)
            //{
            //    case Keys.Up:
            //        playerSprite.Top -= playerSpeed;
            //        break;
            //    case Keys.Down:
            //        playerSprite.Top += playerSpeed;
            //        break;
            //    case Keys.Left:
            //        playerSprite.Left -= playerSpeed;
            //        break;
            //    case Keys.Right:
            //        playerSprite.Left += playerSpeed;
            //        break;
            //}

        }        
    }
}
