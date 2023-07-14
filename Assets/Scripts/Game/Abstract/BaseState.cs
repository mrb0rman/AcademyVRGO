namespace Script.Game
{
    public abstract class BaseState
    {
        protected Enemy _enemy;

        public BaseState(Enemy enemy)
        {
            _enemy = enemy;
        }

        public abstract void Enter();
        public abstract void Update();
        public abstract void Exit();
    }
}