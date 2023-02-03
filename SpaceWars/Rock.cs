using SpaceWars.Properties;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SpaceWars
{
    internal class Rock : EnvirenmentSprite
    {
        public Rock(Control container) : base(container)
        {
            Pb.Image = Resources.Rock;
        }

        public override void Collide(Sprite another, Game game)
        {
            if (another is Ship)
            {
                game.Ship.Pb.Image = Resources.CrashedShip;
                game.Over();
            }

            else if (another is Rocket)
            {
                game.ScoreUp();
                GoToStart();
            }
        }
    }
}
