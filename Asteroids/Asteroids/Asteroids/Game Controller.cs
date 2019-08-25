//Used to control all objects that dont directly relate to the UI.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Asteroids
{       
    public class Game_Controller
    {
        private Player[] players;

        public Game_Controller() //Constructor
        {
            const int NPLAYERS = 1;

            players = new Player[NPLAYERS];

            players[0] = new Player(50, 50, 60, 60);            
        }
        
        public PictureBox getPlayerSprite(GroupBox gameBox, int playerIndex) //used to pass the players pictureBox object back to the form
        {            
            return players[playerIndex].newSprite(gameBox, playerIndex);            
        }

        public void GameFrame(int velHorizontal, int velVertical) //The main game loop
        {            
            foreach (Player player in players) //Move all the players
            {
                player.MovePlayer(velHorizontal, velVertical);
            }
        }
    }
}
