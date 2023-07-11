using System;
using UnityEngine;

namespace Script
{
    public class ObserverSecond : IObserver
    {
        public void Update()
        {
            Debug.Log("Наблюдатель #2");
        }
    }
}

