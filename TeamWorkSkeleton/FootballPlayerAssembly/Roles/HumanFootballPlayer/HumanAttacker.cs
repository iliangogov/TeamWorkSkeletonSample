﻿namespace TeamWork.Models.Roles.HumanFootballPlayer
{
    using Global.Contracts;
    using Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class HumanAttacker : Human
        {
            internal HumanAttacker(IFootballPlayer player) 
                : base(player)
            {
            }

            internal HumanAttacker(string name) : base(name)
            {
            }

            internal HumanAttacker(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints)
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }    
}
