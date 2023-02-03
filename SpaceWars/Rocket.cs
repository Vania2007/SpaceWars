using SpaceWars.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpaceWars
{
    internal class Rocket : Sprite
    {
        const int speed = 30;
        const int size = 150;
        public Rocket(Control container) : base(container)
        {
            Pb.Image = Resources.Rocket;
            Pb.Size = new Size(size, size / 2);
            Pb.Location = new Point(); // Point(Ship.Pb.Location.X, Ship.Pb.Location.Y) поточне положення коробля
        }
        public void Accelerate()
        {
            SpeedX = speed;
        }
        public override void Collide(Sprite another, Game game) { }
    }
}
