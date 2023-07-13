using System;
using UnityEngine;

namespace Script.Game
{
    public class ScoreSystem : Observer
    {
        public Observable player;
        private void Start()
        {
           player.AddObserver(this);
        }

        public override void OnNotify(int score)
        {
            if (score == 10)
            {
                
            }
        }
    }
}