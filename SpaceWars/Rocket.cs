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
        const int speed = 60;
        const int size = 100;
        public Ship Ship { get; set; }
        public Rocket(Control container, Ship ship) : base(container)
        {
            Pb.Image = Resources.Rocket;
            Pb.Size = new Size(size, size / 2);
            Pb.Visible = false;
            Ship = ship;
            Ship.Rocket = this;
        }
        public void Accelerate()
         {
            if (SpeedX != 0) return;
            Pb.Location = Ship.Pb.Location;
            Pb.Visible = true;
            SpeedX = speed;
        }
        public override void Collide(Sprite another, Game game) { }

        public override void Move()
        {
            base.Move();
            if(Pb.Location.X > Container.ClientSize.Width + Pb.Width)
            {
                Pb.Visible = false;
                SpeedX = 0;
            }
        }
    }
}
