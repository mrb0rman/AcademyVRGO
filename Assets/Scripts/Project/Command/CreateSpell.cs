using System;
using UnityEngine;

namespace Script.Project
{
    public class CreateSpell : ISpellCommand
    {
        private Spell spell;
        private SpellType type;
        private Player player;
        private static float offset = -4f;
        private FactorySpell factorySpell = new FactorySpell();

        public CreateSpell(SpellType type, Player player)
        {
            this.type = type;
            this.player = player;
            spell = factorySpell.Create(type);
        }

        public void Execute()
        {
            spell.transform.position = player.transform.position
                + player.transform.up * 1.5f +player.transform.right * offset;
            spell.transform.SetParent(player.transform);
            offset += 2f;
        }
        public void ExecuteUndo()
        {
            offset -= 2f;
            GameObject.Destroy(spell.gameObject);
        }
    }
}


