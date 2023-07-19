using System;
using DG.Tweening;
using UnityEngine;

namespace Script.Project
{
    public class CreateSpell
    {
        public Spell spell;
        private PlayerConroller playerConroller;
        private static float offset = -4f;
        private FactorySpell factorySpell = new FactorySpell();

        public CreateSpell(SpellType type, PlayerConroller playerConroller)
        {
            this.playerConroller = playerConroller;
            spell = factorySpell.Create(type);
        }

        public void Execute()
        {
            spell.transform.localScale = Vector3.zero;
            spell.transform.position = playerConroller.player.transform.position
                                       + playerConroller.player.transform.up * 1.5f + playerConroller.player.transform.right * offset;
            spell.transform.SetParent(playerConroller.player.transform);
            offset += 2f;
            spell.transform.DOScale(1f, 1f);
            playerConroller.Waste();
        }
        public void ExecuteUndo()
        {
            offset -= 2f;
            spell.transform.DOScale(2f, 1f);
            spell.Renderer.material.DOColor(Color.black, 2f);
            GameObject.Destroy(spell.gameObject,2f);
        }
    }
}


