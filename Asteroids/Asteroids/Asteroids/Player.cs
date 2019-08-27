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

            Tuple<int, int> velocity; //Item 1 = X, item 2 = Y
            velocity = getVelocity(velHorizontal, velVertical);

            playerSprite.Top -= (playerSpeed * velocity.Item1);
            playerSprite.Left -= (playerSpeed * velocity.Item2);
        }        

        private Tuple<int, int> getVelocity(int velHorizontal, int velVertical) //Get velocities X and Y components
        {
            int x = 0;
            int y = 0;

            return Tuple.Create(x, y); //Item 1 is X, item 2 is Y
        }
    }
}
