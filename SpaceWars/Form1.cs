using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceWars
{
    public partial class Form1 : Form
    {
        Game game;
        public Form1()
        {
            InitializeComponent();
            game = new Game(this);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            game.Update();
            label1.Text = $"Score: {game.Score}";
            if (game.IsOver) timer1.Stop();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
                game.Ship.AccelerateUp();
            if (e.KeyCode == Keys.S)
                game.Ship.AccelerateDown();
            if (e.KeyCode == Keys.Space)
                game.Rocket. // Accelerate(); - не висвічується
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            game.Ship.Stop();
        }
    }
}
