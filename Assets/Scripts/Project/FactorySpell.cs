using UnityEngine;

namespace Script.Project
{
    public class FactorySpell
    {
        private SpellConfig spellConfig;
        private Spell prefab;

        public Spell Create(SpellType type)
        {
            spellConfig = Resources.Load<SpellConfig>("SpellConfig");
            prefab = Resources.Load<Spell>("Spell");
            var spell = GameObject.Instantiate(prefab);
            var model = spellConfig.Get(type);
            spell.Renderer.material.SetColor("_Color", model.color);
            spell.damage = model.damage;
            spell.speed = model.speed;
            spell.timeLife = model.timeLife;

            return spell;
        }
    }
}


