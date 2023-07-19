using System;
using System.Collections.Generic;
using UnityEngine;

namespace Script.Project
{
    [CreateAssetMenu(fileName = "SpellConfig", menuName = "Configs/SpellConfig", order = 0)]
    public class SpellConfig : ScriptableObject
    {
        [SerializeField] private SpellCharacter[] spells;

        [NonSerialized] private bool _inited;

        private Dictionary<SpellType, SpellCharacter> dictionarySpell = new Dictionary<SpellType, SpellCharacter>();

        public void Init()
        {
            foreach (var spell in spells)
            {
                dictionarySpell.Add(spell.type, spell);
            }
        }

        public SpellCharacter Get(SpellType type)
        {
            if (!_inited)
            {
                Init();
                _inited = !_inited;
            }
            return dictionarySpell[type];
        }
    }
}

[Serializable]
public struct SpellCharacter
{
    public SpellType type;
    public Color color;
    public float damage;
    public float speed;
    public float timeLife;

}

public enum SpellType
{
    Fire,
    Air,
    Earth,
    Water
}

