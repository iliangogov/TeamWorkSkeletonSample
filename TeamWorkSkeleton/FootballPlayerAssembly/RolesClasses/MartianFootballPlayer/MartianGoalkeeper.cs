﻿namespace FootballPlayerAssembly.RolesClasses.MartianFootballPlayer
{
    using FootballPlayerFactoryClasses.GenericFootballPlayerClasses;
    using FootballPlayerAssembly.SpeciesAbstractClasses;

    public static partial class FootballPlayerFactory
    {
        internal class MartianGoalkeeper : Martian
        {
            internal MartianGoalkeeper(FootballPlayerFactoryClasses.GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer player)
                : base(player)
            {
            }

            internal MartianGoalkeeper(string name) : base(name)
            {
            }

            internal MartianGoalkeeper(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints)
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}
