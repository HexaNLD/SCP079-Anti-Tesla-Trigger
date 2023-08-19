using System;
using Exiled.API.Features;
using Server = Exiled.Events.Handlers.Server;
using Tesla = Exiled.API.Features.TeslaGate;

namespace SCP079.AntiTeslaTrigger
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "Scp079 Anti-Tesla-Trigger";
        public override string Author => "Hexa";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(7, 2, 0);

        public override void OnEnabled()
        {
            Server.RoundStarted += OnRoundStart;
        }

        public override void OnDisabled()
        {
            Server.RoundStarted -= OnRoundStart;
        }

        private void OnRoundStart()
        {
            if (Config.IsEnabled)
            {
                Tesla.IgnoredRoles.Add(PlayerRoles.RoleTypeId.Scp079);

                if (Config.Debug)
                {
                    Log.Debug("Disabled tesla triggering for SCP-079");
                }
            }
        }
        }
    }