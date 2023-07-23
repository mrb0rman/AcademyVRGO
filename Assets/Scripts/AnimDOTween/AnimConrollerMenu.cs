using DG.Tweening;
using UnityEngine;

namespace Script
{
    public class AnimConrollerMenu
    {
        public Sequence sequence { get; private set; }
        public AnimConrollerMenu()
        {

        }

        

        public void SequenceKill()
        {
            sequence.Kill();
        }
    }
}