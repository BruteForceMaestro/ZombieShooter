using Exiled.API.Interfaces;

namespace ZombieShooter
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; }
        static public int mags = 3;
    }
}
