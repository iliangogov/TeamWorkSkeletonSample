﻿namespace TeamWork.Models.Factory.Models
{
    using Spcies.NameGenerator;
    using FootballPlayer = Abstract.FootballPlayer;

    public static partial class FootballPlayerFactory
    {
        /// <summary>
        /// Creates a new Human player object 
        /// applying previously generated set of base 
        /// FootballPlayer base abstract stats
        /// wrapped in a GenericFootballPlayer object
        /// </summary>
        /// <param name="baseStats"> 
        /// set of stats wrapped in a GenericFootballPlayer object 
        /// </param>
        /// <returns>new Human(Position) object</returns>
        private static FootballPlayer CreateHumanAttacker
            (Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetHumanName();
            var newPlayer = new FootballPlayerAssembly.RolesClasses.HumanFootballPlayer.FootballPlayerFactory
                .HumanAttacker(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateHumanDefender
            (Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetHumanName();
            var newPlayer = new FootballPlayerAssembly.RolesClasses.HumanFootballPlayer.FootballPlayerFactory
                .HumanDefender(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateHumanMidfielder
            (Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetHumanName();
            var newPlayer = new FootballPlayerAssembly.RolesClasses.HumanFootballPlayer.FootballPlayerFactory
                .HumanMidfielder(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateHumanGoalkeeper
            (Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetHumanName();
            var newPlayer = new FootballPlayerAssembly.RolesClasses.HumanFootballPlayer.FootballPlayerFactory
                .HumanGoalkeeper(baseStats);
            return newPlayer;
        }

        private static string GetHumanName()
        {
            return HumanNameGenerator.GenerateName();
        }
    }
}
