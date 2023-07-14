namespace Script.Game
{
    public class IdleState : BaseState
    {
        public IdleState(Enemy enemy) : base(enemy)
        {
        }
        public override void Enter()
        {
        }
        public override void Update()
        {
            if (!_enemy.isAttacking)
            {
                _enemy.ChangeState(EnemyState.Attack);
            }
        }
        public override void Exit()
        {
        }
    }
}