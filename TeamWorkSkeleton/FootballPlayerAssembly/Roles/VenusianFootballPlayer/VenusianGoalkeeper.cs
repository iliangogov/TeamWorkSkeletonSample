﻿namespace TeamWork.Models.Roles.VenusianFootballPlayer
{
    using Global.Contracts;
    using Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class VenusianGoalkeeper : Venusian
        {
            internal VenusianGoalkeeper(string name)
                : base(name)
            {
            }

            internal VenusianGoalkeeper(IFootballPlayer player) 
                : base(player)
            {
            }

            internal VenusianGoalkeeper(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) 
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}