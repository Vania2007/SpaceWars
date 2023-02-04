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
        Dictionary<Keys, GameActions> keys = new Dictionary<Keys, GameActions>()
        {
            [Keys.W] = GameActions.Up,
            [Keys.S] = GameActions.Down,
            [Keys.Space] = GameActions.Shoot
        };
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
            if (!keys.ContainsKey(e.KeyCode)) return;
            game.Manage(keys[e.KeyCode]);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            game.Ship.Stop();
        }
    }
}
