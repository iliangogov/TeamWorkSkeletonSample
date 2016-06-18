﻿namespace RandomizersAssembly.StaticRandomizersClasses
{
    using System;

    public static class GenericRandomization
    {
        static GenericRandomization()
        {
             Random = new Random();
        }

        public static Random Random { get; private set; }
    }
}
