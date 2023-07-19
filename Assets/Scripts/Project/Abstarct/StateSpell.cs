namespace Script.Project
{
    public abstract class StateSpell
    {
        protected Invoker invoker;
        protected PlayerConroller playerConroller;
        protected StateMachine stateMachine;
        
        public virtual void Enter(PlayerConroller playerConroller, Invoker invoker, StateMachine stateMachine)
        {
            this.playerConroller = playerConroller;
            this.invoker = invoker;
            this.stateMachine = stateMachine;
        }

        public virtual void HandleInput()
        {

        }

        public virtual void LogicUpdate()
        {

        }

        public virtual void PhysicsUpdate()
        {

        }

        public virtual void Exit()
        {

        }
    }
}