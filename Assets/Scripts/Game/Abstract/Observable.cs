using System.Collections.Generic;
using UnityEngine;

namespace Script.Game
{
    public abstract class Observable : MonoBehaviour
    {
        private List<Observer> _observers = new List<Observer>();

        public void AddObserver(Observer observer)
        {
            _observers.Add(observer);
        }

        public void NotifyObservers(int score)
        {
            foreach (var observer in _observers)
            {
                observer.OnNotify(score);
            }
        }
    }
}