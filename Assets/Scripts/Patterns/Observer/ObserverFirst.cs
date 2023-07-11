using System;
using UnityEngine;

namespace Script
{
    public class ObserverFirst : IObserver
    {
        public void Update()
        {
            Debug.Log("Наблюдатель #1");
        }
    }
}

