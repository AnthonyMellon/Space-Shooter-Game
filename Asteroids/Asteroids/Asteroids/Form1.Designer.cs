namespace Asteroids
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxGame = new System.Windows.Forms.GroupBox();
            this.groupBoxUI = new System.Windows.Forms.GroupBox();
            this.label_PLYR_ROT = new System.Windows.Forms.Label();
            this.label_PLYR_Y = new System.Windows.Forms.Label();
            this.Label_PLYR_X = new System.Windows.Forms.Label();
            this.textBox_PLYR_ROT = new System.Windows.Forms.TextBox();
            this.textBox_PLYR_Y = new System.Windows.Forms.TextBox();
            this.textBox_PLYR_X = new System.Windows.Forms.TextBox();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.groupBoxUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGame
            // 
            this.groupBoxGame.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGame.Name = "groupBoxGame";
            this.groupBoxGame.Size = new System.Drawing.Size(800, 400);
            this.groupBoxGame.TabIndex = 1;
            this.groupBoxGame.TabStop = false;
            // 
            // groupBoxUI
            // 
            this.groupBoxUI.Controls.Add(this.label_PLYR_ROT);
            this.groupBoxUI.Controls.Add(this.label_PLYR_Y);
            this.groupBoxUI.Controls.Add(this.Label_PLYR_X);
            this.groupBoxUI.Controls.Add(this.textBox_PLYR_ROT);
            this.groupBoxUI.Controls.Add(this.textBox_PLYR_Y);
            this.groupBoxUI.Controls.Add(this.textBox_PLYR_X);
            this.groupBoxUI.Location = new System.Drawing.Point(818, 12);
            this.groupBoxUI.Name = "groupBoxUI";
            this.groupBoxUI.Size = new System.Drawing.Size(200, 400);
            this.groupBoxUI.TabIndex = 2;
            this.groupBoxUI.TabStop = false;
            // 
            // label_PLYR_ROT
            // 
            this.label_PLYR_ROT.AutoSize = true;
            this.label_PLYR_ROT.Location = new System.Drawing.Point(6, 138);
            this.label_PLYR_ROT.Name = "label_PLYR_ROT";
            this.label_PLYR_ROT.Size = new System.Drawing.Size(79, 13);
            this.label_PLYR_ROT.TabIndex = 5;
            this.label_PLYR_ROT.Text = "Player Rotation";
            // 
            // label_PLYR_Y
            // 
            this.label_PLYR_Y.AutoSize = true;
            this.label_PLYR_Y.Location = new System.Drawing.Point(6, 81);
            this.label_PLYR_Y.Name = "label_PLYR_Y";
            this.label_PLYR_Y.Size = new System.Drawing.Size(46, 13);
            this.label_PLYR_Y.TabIndex = 4;
            this.label_PLYR_Y.Text = "Player Y";
            // 
            // Label_PLYR_X
            // 
            this.Label_PLYR_X.AutoSize = true;
            this.Label_PLYR_X.Location = new System.Drawing.Point(6, 23);
            this.Label_PLYR_X.Name = "Label_PLYR_X";
            this.Label_PLYR_X.Size = new System.Drawing.Size(46, 13);
            this.Label_PLYR_X.TabIndex = 3;
            this.Label_PLYR_X.Text = "Player X";
            // 
            // textBox_PLYR_ROT
            // 
            this.textBox_PLYR_ROT.Location = new System.Drawing.Point(7, 154);
            this.textBox_PLYR_ROT.Name = "textBox_PLYR_ROT";
            this.textBox_PLYR_ROT.ReadOnly = true;
            this.textBox_PLYR_ROT.Size = new System.Drawing.Size(100, 20);
            this.textBox_PLYR_ROT.TabIndex = 2;
            // 
            // textBox_PLYR_Y
            // 
            this.textBox_PLYR_Y.Location = new System.Drawing.Point(9, 97);
            this.textBox_PLYR_Y.Name = "textBox_PLYR_Y";
            this.textBox_PLYR_Y.ReadOnly = true;
            this.textBox_PLYR_Y.Size = new System.Drawing.Size(100, 20);
            this.textBox_PLYR_Y.TabIndex = 1;
            // 
            // textBox_PLYR_X
            // 
            this.textBox_PLYR_X.Location = new System.Drawing.Point(7, 39);
            this.textBox_PLYR_X.Name = "textBox_PLYR_X";
            this.textBox_PLYR_X.ReadOnly = true;
            this.textBox_PLYR_X.Size = new System.Drawing.Size(100, 20);
            this.textBox_PLYR_X.TabIndex = 0;
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 663);
            this.Controls.Add(this.groupBoxUI);
            this.Controls.Add(this.groupBoxGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBoxUI.ResumeLayout(false);
            this.groupBoxUI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGame;
        private System.Windows.Forms.GroupBox groupBoxUI;
        private System.Windows.Forms.Label Label_PLYR_X;
        private System.Windows.Forms.TextBox textBox_PLYR_ROT;
        private System.Windows.Forms.TextBox textBox_PLYR_Y;
        private System.Windows.Forms.TextBox textBox_PLYR_X;
        private System.Windows.Forms.Label label_PLYR_ROT;
        private System.Windows.Forms.Label label_PLYR_Y;
        private System.Windows.Forms.Timer timerGame;
    }
}

