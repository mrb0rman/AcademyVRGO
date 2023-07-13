using System;
using UnityEngine;
using Unity.VisualScripting;

namespace Script.Game
{
    public class FactoryEnemy
    {
        EnemyConfig enemyConfig;
        public GameObject Create(EnemyType type)
        {
            enemyConfig = Resources.Load<EnemyConfig>("EnemyConfig");
            var enemy = GameObject.Instantiate(Resources.Load<Enemy>("Enemy"));
            var model = enemyConfig.Get(type);
            enemy.MeshFilter.mesh = model.mesh;
            enemy.Renderer.material.SetColor("_Color", model.color);
            enemy.transform.localScale = model.size;
            enemy.HP = model.HP;
            enemy.damage = model.damage;
            return enemy.GameObject();
        }
    }

}

