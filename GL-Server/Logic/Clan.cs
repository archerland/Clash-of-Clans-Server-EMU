﻿namespace GL.Servers.CoC.Logic
{
    using System.Collections.Generic;

    using GL.Servers.CoC.Core;

    using Newtonsoft.Json;

    internal class Clan
    {
        [JsonProperty("high_id")]     internal int HighID;
        [JsonProperty("low_id")]      internal int LowID;

        [JsonProperty("tag")]
internal string Tag;
        [JsonProperty("name")]        internal string Name;
        [JsonProperty("type")]
internal string Type;
        [JsonProperty("description")] internal string Description;
        [JsonProperty("location")]
internal string Location;

        [JsonProperty("lvl")]         internal int Level;
        [JsonProperty("exp")]         internal int Experience;

        [JsonProperty("origin")]      internal int Origin;
        [JsonProperty("badge")]       internal int Badge;

        [JsonProperty("required_trophies")] internal int RequiredTrophies;
        [JsonProperty("war_frequency")]  internal int WarFreguency;

        [JsonProperty("members")]  internal int Members;
        [JsonProperty("members_list")]  internal List<Member> MemberList;

        [JsonProperty("war_wins")]    internal int WarWins;
        [JsonProperty("war_loses")]   internal int WarLoses;
        [JsonProperty("war_equals")]  internal int WarEquals;

        [JsonProperty("logs_showed")] internal bool WarLogsShowed;
        [JsonProperty("war_amical")]  internal bool WarAmical;

        internal object Gate            = new object();

        /// <summary>
        /// Initializes a new instance of the <see cref="Clan"/> class.
        /// </summary>
        internal Clan()
        {
            // Clan.
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Clan"/> class.
        /// </summary>
        /// <param name="HighID">The high identifier.</param>
        /// <param name="LowID">The low identifier.</param>
        internal Clan(int HighID = Constants.ServerID, int LowID = 0) : this()
        {
            this.HighID     = HighID;
            this.LowID      = LowID;
        }

        internal byte[] ToBytes
        {
            get
            {
                List<byte> Packet = new List<byte>();

                return Packet.ToArray();
            }
        }
    }
}
