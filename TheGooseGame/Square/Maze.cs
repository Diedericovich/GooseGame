﻿using TheGooseGame.Intefaces;

namespace TheGooseGame.Square
{
    internal class Maze : MySquare
    {
        public override void Action(IPlayer player)
        {
            player.Position = 39;
        }
    }
}