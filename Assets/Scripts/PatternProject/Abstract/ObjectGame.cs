namespace Script
{
    public abstract class ObjectGame
    {
        public IObjectState state { get; set; }
        public abstract void On();
        public abstract void Off();
    }
}