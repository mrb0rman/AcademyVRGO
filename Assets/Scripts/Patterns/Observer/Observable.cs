
// Конкретно наблюдаемый обект

using System;
using System.Collections.Generic;

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
            foreach (IObserver observer in observers)
                observer.Update();
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
