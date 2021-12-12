using Rocket.API;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using SimpleFastSalvage.Configuration;
using SimpleFastSalvage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFastSalvage
{
    public class SimpleFastSalvagePlugin : RocketPlugin<SimpleFastSalvageConfiguration>
    {
        public static SimpleFastSalvagePlugin Instance { get; set; }

        private void Events_OnPlayerConnected(UnturnedPlayer player)
        {
            foreach (Group group in Configuration.Instance.Groups)
            {
                if (player.HasPermission(group.Permission)) player.Player.interact.sendSalvageTimeOverride(group.Interval);
            }
        }

        protected override void Load()
        {
            Instance = this;
            U.Events.OnPlayerConnected += Events_OnPlayerConnected;
            Logger.Log("Plugin Creado Por Margarita#8172 (EnvyHosting) ");
        }

        protected override void Unload()
        {
            U.Events.OnPlayerConnected -= Events_OnPlayerConnected;
        }

    }
}
