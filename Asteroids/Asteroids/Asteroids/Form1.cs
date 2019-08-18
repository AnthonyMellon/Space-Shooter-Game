using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Asteroids
{
    public partial class Form1 : Form
    {
        Game_Controller controller;

        KeyEventArgs key;

        public Form1()
        {
            InitializeComponent();

            controller = new Game_Controller();
            Controls.Add(controller.getPlayerSprite(groupBoxGame, 0));
            key = new KeyEventArgs(Keys.KeyCode);

            groupBoxGame.SendToBack();            
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {                        
            controller.GameFrame(key);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            key = e;
        }
    }
}
