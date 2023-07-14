using UnityEngine;

namespace Script.Game
{
    public class AttackState : BaseState
    {
        private Color startColor;
        public AttackState(Enemy enemy) : base(enemy)
        {
            
        }

        public override void Enter()
        {
            startColor = _enemy.Renderer.material.color;
            _enemy.Renderer.material.SetColor("_Color", Color.red);
        }

        public override void Update()
        {
           
            if(!_enemy.isAttacking)
            {
                _enemy.ChangeState(EnemyState.Idle);
            }
        }

        public override void Exit()
        {
            _enemy.Renderer.material.SetColor("_Color", startColor);
        }
    }
}