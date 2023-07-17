
// Разделить данные и логику на Enemy и EnemyConroller (сделать так везде)
// Паттерн наблюдатель - использовать event

using System.Collections.Generic;
using UnityEngine;

namespace Script.Game
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private MeshFilter meshFilter;
        [SerializeField] private Renderer renderer;
        public MeshFilter MeshFilter => meshFilter;
        public Renderer Renderer => renderer;
        public float HP;
        public float damage;
        public EnemyState currentState { get; private set; }
        public bool isAttacking { get; private set; }

        private Dictionary<EnemyState, BaseState> stateDictionary; 

        private void Awake()
        {
            stateDictionary = new Dictionary<EnemyState, BaseState>()
            {
                { EnemyState.Idle, new IdleState(this) },
                { EnemyState.Attack, new AttackState(this) }
            };
        }

        private void Start()
        {
            ChangeState(EnemyState.Idle);
        }

        private void Update()
        {
            if (stateDictionary.ContainsKey(currentState))
            {
                stateDictionary[currentState].Update();
            }
        }

        public void ChangeState(EnemyState newState)
        {
            if (stateDictionary.ContainsKey((currentState)))
            {
                isAttacking = !isAttacking;
                stateDictionary[currentState].Exit();
            }

            currentState = newState;

            if (stateDictionary.ContainsKey(newState))
            {
                stateDictionary[newState].Enter();
            }
        }

    }
}


