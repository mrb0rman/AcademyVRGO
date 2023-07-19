using UnityEngine;

namespace Script.Project
{
    public class IdleStateSpell : StateSpell
    {
        private CreateSpell spellCommand;
        private bool buttonF;
        private bool buttonU;

        public override void Enter(PlayerConroller playerConroller, Invoker invoker, StateMachine stateMachine)
        {
            base.Enter(playerConroller, invoker, stateMachine);
            
        }

        public override void HandleInput()
        {
            base.HandleInput();
            buttonF = Input.GetKeyDown(KeyCode.F);
            buttonU = Input.GetKeyDown(KeyCode.U);
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();
            if (buttonF && invoker.sCommand.Count < 5)
            {
                PhysicsUpdate();
            }
            else if(buttonU)
                stateMachine.ChangeState(new DestroyStateSpell(), playerConroller, invoker, stateMachine);
        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();
            spellCommand = new CreateSpell(SpellType.Fire, playerConroller);
            invoker.Execute(spellCommand);
        }

        public override void Exit()
        {
            base.Exit();
        }
        
    }
}