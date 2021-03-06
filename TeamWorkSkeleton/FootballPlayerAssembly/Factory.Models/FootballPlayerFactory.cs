﻿namespace TeamWork.Models.Factory.Models
{
    using System.Reflection;

    using Abstract;
    using Global.Contracts;
    using Global.Enumerations.Factory;
    using Global.Enumerations.Utils;
    using Global.Randomization;
    using Settings;
    using Settings.Abstract;

    /// <summary>
    /// Methods for generating a random player
    /// </summary>
    public partial class FootballPlayerFactory : IFactory
    {
        private readonly IFactorySettings AttackerSettings;
        private readonly IFactorySettings DefenderSettings;
        private readonly IFactorySettings MidfielderSettings;
        private readonly IFactorySettings GoalkeeperSettings;

        public FootballPlayerFactory()
        {
            this.AttackerSettings = new AttackerSettings();
            this.DefenderSettings = new DefenderSettings();
            this.MidfielderSettings = new MidfielderSettings();
            this.GoalkeeperSettings = new GoalkeeperSettings();
        }

        /// <summary>
        /// Randomly pick a Position.
        /// Call the corresponding method.
        /// </summary>
        /// <returns>new FootballPlayer object</returns>
        public IFootballPlayer CreatePlayer()
        {
            // Randomly generate a position and pass it along.
            var enumSize = EnumerationSize.GetPositionTypeSize();

            var positionEnumIndex = GenericRandomization.Random.Next(0, enumSize);

            var positionName = (PositionType)positionEnumIndex;

            var newlyGeneratedPlayer = CreatePlayerByPosition(positionName);

            return newlyGeneratedPlayer;
        }

        /// <summary>
        /// Create a new FootballPlayer by a givern position
        /// </summary>
        /// <param name="position"></param>
        /// <returns>FootballPlayer object</returns>
        public IFootballPlayer CreatePlayerByPosition(PositionType position)
        {
            const string methodNameFormat = "Create{0}";

            var methodName = string.Format(methodNameFormat, position);

            var method = typeof(FootballPlayerFactory)
                .GetMethod(methodName,
                    BindingFlags.NonPublic | BindingFlags.Instance);

            var newlyGeneratedPlayer =
                (FootballPlayer)method
                    .Invoke(this, new object[] { });

            return newlyGeneratedPlayer;
        }

        /// <summary>
        /// Generate appropriate stats for the currently selected position
        /// and pick a species.
        /// Pass the date to the corresponding contucting method.
        /// </summary>
        /// <returns></returns>
        private IFootballPlayer CreateAttacker()
        {
            // Generate base stats.
            var baseStatsGenericPlayer = CreateGeneric(this.AttackerSettings);

            // Pick Species.
            var species = PickSpecies();

            // Call the corresponing constructor intermediate method.
            var methodName = $"Create{species}Attacker";
            var creatingMethod = typeof(FootballPlayerFactory).GetMethod(methodName,
                BindingFlags.NonPublic | BindingFlags.Instance);

            var newAttacker = (FootballPlayer)creatingMethod
                .Invoke(this, new object[] { baseStatsGenericPlayer });

            return newAttacker;
        }

        private IFootballPlayer CreateDefender()
        {
            // Generate base stats.
            var baseStatsGeneric = CreateGeneric(this.DefenderSettings);

            // Pick Species.
            var species = PickSpecies();

            // Call the corresponing constructor intermediate method.
            var methodName = $"Create{species}Defender";
            var creatingMethod = typeof(FootballPlayerFactory).GetMethod(methodName,
                BindingFlags.NonPublic | BindingFlags.Instance);

            var newDefender = (FootballPlayer)creatingMethod
                .Invoke(this, new object[] { baseStatsGeneric });

            return newDefender;
        }

        private IFootballPlayer CreateMidfielder()
        {
            // TODO:
            // Generate base stats.
            var baseStatsGeneric = CreateGeneric(this.MidfielderSettings);

            // Pick Species.
            var species = PickSpecies();

            // Call the corresponing constructor intermediate method.
            var methodName = $"Create{species}Midfielder";
            var creatingMethod = typeof(FootballPlayerFactory).GetMethod(methodName,
                BindingFlags.NonPublic | BindingFlags.Instance);

            var newMidfielder = (FootballPlayer)creatingMethod
                .Invoke(this, new object[] { baseStatsGeneric });

            return newMidfielder;
        }

        private IFootballPlayer CreateGoalkeeper()
        {
            // Generate base stats.
            var baseStatsGeneric = CreateGeneric(this.GoalkeeperSettings);

            // Pick Species.
            var species = PickSpecies();

            // Call the corresponing constructor intermediate method.
            var methodName = $"Create{species}Goalkeeper";
            var creatingMethod = typeof(FootballPlayerFactory).GetMethod(methodName,
                BindingFlags.NonPublic | BindingFlags.Instance);

            var newGoalkeeper = (FootballPlayer)creatingMethod
                .Invoke(this, new object[] { baseStatsGeneric });

            return newGoalkeeper;
        }

        private IFootballPlayer CreateGeneric(IFactorySettings settings)
        {
            const string Name = "placeholder";

            var pass = GenericRandomization.Random.Next(
                settings.Pass.Min,
                settings.Pass.Max);

            var shoot = GenericRandomization.Random.Next(
                settings.Shoot.Min,
                settings.Shoot.Max);

            var dribble = GenericRandomization.Random.Next(
                settings.Dribble.Min,
                settings.Dribble.Max);

            var save = GenericRandomization.Random.Next(
                settings.Save.Min,
                settings.Save.Max);

            var tackle = GenericRandomization.Random.Next(
                settings.Tackle.Min,
                settings.Tackle.Max);

            var intercept = GenericRandomization.Random.Next(
                settings.Intercept.Min,
                settings.Intercept.Max);

            var awareness = GenericRandomization.Random.Next(
                settings.Awareness.Min,
                settings.Awareness.Max);

            var ap = GenericRandomization.Random.Next(
                settings.Ap.Min,
                settings.Ap.Max);

            var genericFootballPlayer = new Generic.FootballPlayerFactory.GenericFootballPlayer(
                Name, pass, shoot, dribble, save, tackle, intercept, awareness, ap);

            return genericFootballPlayer;
        }

        private string PickSpecies()
        {
            // Get size of enum 
            var enumSize = EnumerationSize.GetSpeciesTypeSize();

            var speciesIndex = GenericRandomization.Random.Next(0, enumSize);
            var speciesName = (SpeciesType)speciesIndex;

            return speciesName.ToString();
        }
    }
}
