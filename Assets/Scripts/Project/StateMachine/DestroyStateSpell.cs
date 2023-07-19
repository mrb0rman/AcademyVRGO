using UnityEngine;

namespace Script.Project
{
    public class DestroyStateSpell : StateSpell
    {

        public override void Enter(PlayerConroller playerConroller, Invoker invoker, StateMachine stateMachine)
        {
            base.Enter(playerConroller, invoker, stateMachine);
        }

        public override void HandleInput()
        {
            base.HandleInput();
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();
            PhysicsUpdate();
            stateMachine.ChangeState(new IdleStateSpell(), playerConroller, invoker, stateMachine);
        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();
            invoker.Undo();
        }

        public override void Exit()
        {
            base.Exit();
        }
    }
}