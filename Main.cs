using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;

namespace ZombieShooter
{
    public class Main : Plugin<Config>
    {
        EventHandlers EventHandler = new EventHandlers();

        public override void OnEnabled()
        {
            base.OnEnabled();
            EventHandler = new EventHandlers();
            Player.ChangingRole += EventHandler.RoleChange;
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
            EventHandler = null;
            Player.ChangingRole -= EventHandler.RoleChange;
        }
    }
}
