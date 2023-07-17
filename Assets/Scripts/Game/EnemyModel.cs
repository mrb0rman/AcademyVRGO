using UnityEngine;

namespace Script.Game
{
    public class EnemyModel
    {
        [SerializeField] private MeshFilter meshFilter;
        [SerializeField] private Renderer renderer;
        public MeshFilter MeshFilter => meshFilter;
        public Renderer Renderer => renderer;
        
        public float Hp { get; set; }
        public float Damage { get; set; }
        
        public EnemyState CurrentState { get; private set; }
        public bool IsAttacking { get; private set; }
        
        public delegate void TestEvent(int score);
        public event TestEvent EventScore;
        
        public EnemyModel(float hp, float damage)
        {
            Hp = hp;
            Damage = damage;
        }
        
        public void GetDamage(float damage)
        {
            Hp -= damage;
        }
    }
}