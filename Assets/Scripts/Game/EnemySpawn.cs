using System;
using UnityEngine;

namespace Script.Game
{
    public class EnemySpawn : MonoBehaviour
    {
        private FactoryEnemy factoryEnemy;
        private void Start()
        {
            factoryEnemy = new FactoryEnemy();
            var enemy = factoryEnemy.Create(EnemyType.Goblin);
            enemy.transform.localPosition = gameObject.transform.position;
        }
    }
}


