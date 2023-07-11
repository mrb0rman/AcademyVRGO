
// Конкретно наблюдаемый обект

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Script
{
    public class Observable : IObservable
    {
        private List<IObserver> observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void NotifyObserver()
        {
            if(observers.Count > 0)
            {
                foreach (IObserver observer in observers)
                    observer.Update();
            } else
            {
                Debug.Log("Наблюдатели отсутсвуют");
            }
            
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
