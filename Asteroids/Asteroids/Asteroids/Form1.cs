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

        int velHorizontal;
        int velVertical;        

        public Form1()
        {
            InitializeComponent();

            controller = new Game_Controller();
            Controls.Add(controller.getPlayerSprite(groupBoxGame, 0));          

            groupBoxGame.SendToBack();            
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {                          
            controller.GameFrame(velHorizontal, velVertical);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                velVertical = 1;
            }
            if (e.KeyCode == Keys.Down)
            {
                velVertical = -1;
            }

            if (e.KeyCode == Keys.Left)
            {
                velHorizontal = 1;
            }
            if (e.KeyCode == Keys.Right)
            {
                velHorizontal = -1;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                velVertical = 0;
            }
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                velHorizontal = 0;
            }
        }
    }
}
