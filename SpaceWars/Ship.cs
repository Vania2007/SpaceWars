using SpaceWars.Properties;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SpaceWars
{
    internal class Ship : Sprite
    {
        const int size = 200;
        const int speed = 30;
        public Rocket Rocket { get; set;}
        public Ship(Control container) : base(container)
        {
            Pb.Image = Resources.Ship;
            Pb.Size = new Size(size, size / 2);
            Pb.Location = new Point(container.Width / 10, container.ClientSize.Height / 2);
        }
        public void AccelerateUp()
        {
            SpeedY = -speed;
        }
        public void AccelerateDown()
        {
            SpeedY = speed;
        }
        public void Shoot()
        {
            Rocket.Accelerate();
        }
        public void Stop()
        {
            SpeedY = 0;
        }

        public override void Collide(Sprite another, Game game) { }
    }
}
