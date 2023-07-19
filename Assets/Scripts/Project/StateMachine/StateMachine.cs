namespace Script.Project
{
    public class StateMachine
    {
        public StateSpell CurrentState { get; set; }
        
        public void Initialize(StateSpell startingState, PlayerConroller playerConroller, Invoker invoker, StateMachine stateMachine)
        {
            CurrentState = startingState;
            startingState.Enter(playerConroller, invoker, stateMachine);
        }

        public void ChangeState(StateSpell newState, PlayerConroller playerConroller, Invoker invoker, StateMachine stateMachine)
        {
            CurrentState.Exit();

            CurrentState = newState;
            newState.Enter(playerConroller, invoker, stateMachine);
        }

    }
    
}