﻿namespace TeamWork.Models.Species.Abstract
{
    using Global.Contracts;
    using Models.Abstract;

    internal abstract class Sagittariusian : FootballPlayer
    {
        internal Sagittariusian(IFootballPlayer player) 
            : base(player)
        {
        }

        internal Sagittariusian(string name) 
            : base(name)
        {
        }

        internal Sagittariusian(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints)
            : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
        {
        }
    }
}
