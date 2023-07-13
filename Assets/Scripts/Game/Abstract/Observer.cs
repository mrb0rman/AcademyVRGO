using UnityEngine;

namespace Script.Game
{
    public abstract class Observer : MonoBehaviour
    {
        public abstract void OnNotify(int score);
    }
}