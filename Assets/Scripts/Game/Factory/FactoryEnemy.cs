using UnityEngine;

namespace Script.Game
{
    public class FactoryEnemy
    {
        private EnemyConfig enemyConfig = Resources.Load<EnemyConfig>("EnemyConfig");
        private Enemy prefab = Resources.Load<Enemy>("Enemy");

        public Enemy Create(EnemyType type)
        {
            var enemy = GameObject.Instantiate(prefab);
            var model = enemyConfig.Get(type);
            enemy.MeshFilter.mesh = model.mesh;
            enemy.Renderer.material.SetColor("_Color", model.color);
            enemy.transform.localScale = model.size;
            enemy.HP = model.HP;
            enemy.damage = model.damage;
            return enemy;
        }
    }

}