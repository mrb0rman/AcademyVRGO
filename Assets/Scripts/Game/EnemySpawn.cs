using System;
using UnityEngine;

namespace Script.Game
{
    public class EnemySpawn : Observer
    {
        private FactoryEnemy factoryEnemy;
        private void Start()
        {
            factoryEnemy = new FactoryEnemy();
            var enenmy = factoryEnemy.Create(EnemyType.Goblin);
            enenmy.transform.localPosition = gameObject.transform.position;
        }

        public override void OnNotify(int score)
        {
            
        }
    }
}


