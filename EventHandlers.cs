using Exiled.Events.EventArgs;
using System;

namespace ZombieShooter
{
    class EventHandlers
    {
        public void RoleChange(ChangingRoleEventArgs ev)
        {
            if (ev.NewRole == RoleType.Scp0492)
            {
                Random random = new Random();
                int Num1 = random.Next(1, 4);
                int Num2 = random.Next(1, 4);
                if (Num1 == Num2)
                {
                    ev.Player.ShowHint("You are a zombie shooter!\nPress 1 on your keyboard to equip a gun!", duration: 10f);
                    ev.Items.Add(ItemType.GunCOM15);
                    for (int i = 0; i <= Config.mags; i++)
                    {
                        ev.Items.Add(ItemType.Ammo9x19);
                    }
                }
            }
        }
    }
}
