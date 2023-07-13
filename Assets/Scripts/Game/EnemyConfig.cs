using System;
using System.Collections.Generic;
using UnityEngine;

namespace Script.Game
{
    [CreateAssetMenu(fileName = "EnemyConfig", menuName = "Configs/EnemyConfig", order = 1)]
    public class EnemyConfig : ScriptableObject
    {
        [SerializeField] private EnemyCharacter[] enemies;

        [NonSerialized] private bool _inited;

        private Dictionary<EnemyType, EnemyCharacter> dictionaryEnemy = new Dictionary<EnemyType, EnemyCharacter>();

        public void Init()
        {
            foreach (var enemy in enemies)
            {
                dictionaryEnemy.Add(enemy.type, enemy);
            }
        }

        public EnemyCharacter Get(EnemyType type)
        {
            if (!_inited)
            {
                Init();
            }
            return dictionaryEnemy[type];
        }
    }
}

[Serializable]
public struct EnemyCharacter
{
    public EnemyType type;
    public Mesh mesh;
    public Sprite Sprite;
    public Color color;
    public Vector3 size;
    public float HP;
    public float damage;
    public Collider collider;
}

public enum EnemyType
{
    Ogre,
    Goblin,
    Zombi,
    Ghost
}


