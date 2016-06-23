namespace TeamWork.Models.Factory.Models
{
    using Spcies.NameGenerator;
    using FootballPlayer = Abstract.FootballPlayer;

    public static partial class FootballPlayerFactory
    {
        /// <summary>
        /// Creates a new Neptunian player object 
        /// applying previously generated set of base 
        /// FootballPlayer base abstract stats
        /// wrapped in a GenericFootballPlayer object
        /// </summary>
        /// <param name="baseStats"> 
        /// set of stats wrapped in a GenericFootballPlayer object 
        /// </param>
        /// <returns>new Neptunian(Position) object</returns>
        private static FootballPlayer CreateNeptunianAttacker
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetNeptunianName();
            var newPlayer = new FootballPlayerAssembly.RolesClasses.NeptunianFootballPlayer.FootballPlayerFactory
                .NeptunianAttacker(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateNeptunianDefender
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetNeptunianName();
            var newPlayer = new FootballPlayerAssembly.RolesClasses.NeptunianFootballPlayer.FootballPlayerFactory
                .NeptunianDefender(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateNeptunianMidfielder
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetNeptunianName();
            var newPlayer = new FootballPlayerAssembly.RolesClasses.NeptunianFootballPlayer.FootballPlayerFactory
                .NeptunianMidfielder(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateNeptunianGoalkeeper
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetNeptunianName();
            var newPlayer = new FootballPlayerAssembly.RolesClasses.NeptunianFootballPlayer.FootballPlayerFactory
                .NeptunianGoalkeeper(baseStats);
            return newPlayer;
        }

        private static string GetNeptunianName()
        {
            return NeptunianNameGenerator.GenerateName();
        }
    }
}
