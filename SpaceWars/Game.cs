using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SpaceWars
{
    internal class Game
    {
        public bool IsOver { get; set; } = false; 
        public int Score { get; set; } = 0;
        public Ship Ship { get; }
        public List<Sprite> Sprites { get; } = new List<Sprite>();
        public List<Sprite> CollideSprites { get; } = new List<Sprite>();
        public Game(Control container)
        {
            Ship = new Ship(container);
            Sprites.Add(Ship);
            var rocket = new Rocket(container, Ship);
            Sprites.Add(rocket);
            CollideSprites.Add(Ship);
            CollideSprites.Add(rocket);
            for (int i = 0; i < 5; i++)
            {
                Sprites.Add(new Star(container));
            }
            for (int i = 0; i < 3; i++)
            {
                Sprites.Add(new Rock(container));
            }
        }
        internal void ScoreDown()
        {
            Score -= 5;
        }

        internal void Over()
        {
            IsOver = true;
        }
        public void Update()
        {
            foreach (var sprite in Sprites)
            {
                sprite.Move();
                foreach (var colide in CollideSprites)
                {
                    if (colide.IsCollide(sprite)) sprite.Collide(colide, this);
                }
            }
        }
        internal void ScoreUp()
        {
            Score += 10;
        }
        public void Manage(GameActions action)
        {
            switch (action)
            {
                case GameActions.Up:
                    Ship.AccelerateUp();
                    break;
                case GameActions.Down:
                    Ship.AccelerateDown();
                    break;
                case GameActions.Shoot:
                    Ship.Shoot();
                    break;
                default:
                    break;
            }
        }
    }
}
