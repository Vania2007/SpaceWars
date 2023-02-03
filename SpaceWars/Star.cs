using SpaceWars.Properties;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SpaceWars
{
    internal class Star : EnvirenmentSprite
    {
        public Star(Control container) : base(container)
        {
            Pb.Image = Resources.Star;
        }
        public override void Collide(Sprite another, Game game)
        {
            if(another is Ship)
            {
                game.ScoreUp();
                GoToStart();
            }
            else if (another is Rocket)
            {
                game.ScoreDown();
                GoToStart();
            }
        }
    }
}
