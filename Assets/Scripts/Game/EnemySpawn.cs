using System;
using UnityEngine;

namespace Script.Game
{
    public class EnemySpawn : MonoBehaviour
    {
        private FactoryEnemy factoryEnemy = new FactoryEnemy();
        private void Start()
        {
            var enenmy = factoryEnemy.Create(EnemyType.Goblin);
            enenmy.transform.localPosition = gameObject.transform.position;
        }

    }
}


