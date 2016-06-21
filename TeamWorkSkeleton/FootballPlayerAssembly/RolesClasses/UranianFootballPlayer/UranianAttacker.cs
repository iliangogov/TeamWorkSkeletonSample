﻿namespace FootballPlayerAssembly.RolesClasses.UranianFootballPlayer
{
    using FootballPlayerFactoryClasses.GenericFootballPlayerClasses;
    using SpeciesAbstractClasses;

    public static partial class FootballPlayerFactory
    {
        internal class UranianAttacker : Uranian
        {
            internal UranianAttacker(FootballPlayerFactoryClasses.GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer player) 
                : base(player)
            {
            }

            internal UranianAttacker(string name) 
                : base(name)
            {
            }

            internal UranianAttacker(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) 
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}