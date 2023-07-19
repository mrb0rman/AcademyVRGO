namespace Script.Project
{
    public class PlayerConroller
    {
        public Player player;

        public delegate void WasteMp();

        public event WasteMp Change;

        public PlayerConroller(Player player)
        {
            this.player = player;
            Change += RegenMp;
        }
        public void Waste()
        {
            player.mp = player.mp >= 0 ? player.mp -= 20 : 0;
            Change.Invoke();
        }

        public void RegenMp()
        {
            if(player.mp <= 0)
                player.mp = player.maxMp;
        }
    }
}