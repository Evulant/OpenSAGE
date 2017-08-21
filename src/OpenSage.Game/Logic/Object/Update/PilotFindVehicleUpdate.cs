﻿using OpenSage.Data.Ini.Parser;

namespace OpenSage.Logic.Object
{
    /// <summary>
    /// Instructs the pilot to go find a "friendly" vehicle to enter. AI only.
    /// </summary>
    public sealed class PilotFindVehicleUpdate : ObjectBehavior
    {
        internal static PilotFindVehicleUpdate Parse(IniParser parser) => parser.ParseBlock(FieldParseTable);

        private static readonly IniParseTable<PilotFindVehicleUpdate> FieldParseTable = new IniParseTable<PilotFindVehicleUpdate>
        {
            { "ScanRate", (parser, x) => x.ScanRate = parser.ParseInteger() },
            { "ScanRange", (parser, x) => x.ScanRange = parser.ParseInteger() },
            { "MinHealth", (parser, x) => x.MinHealth = parser.ParseFloat() }
        };

        public int ScanRate { get; private set; }
        public int ScanRange { get; private set; }
        public float MinHealth { get; private set; }
    }
}
