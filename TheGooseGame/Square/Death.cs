﻿using TheGooseGame.Intefaces;

namespace TheGooseGame.Square
{
    internal class Death : MySquare
    {
        public override void Action(IPlayer player)
        {
            player.Position = 0;
        }
    }
}