namespace Script
{
    public interface IState
    {
        public void Heat(Water water);
        public void Frost(Water water);
    }
}

