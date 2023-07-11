using UnityEngine;
using System.Collections;
using Script;

public class _PatternObserver : MonoBehaviour
{
	// Use this for initialization
	void Start()
	{
		IObservable observable = new Observable();
		IObserver observer1 = new ObserverFirst();
        IObserver observer2 = new ObserverSecond();
		observable.AddObserver(observer1);
		observable.NotifyObserver();
        observable.AddObserver(observer2);
        observable.NotifyObserver();
		observable.RemoveObserver(observer1);
        observable.NotifyObserver();
        observable.RemoveObserver(observer2);
        observable.NotifyObserver();
    }

	// Update is called once per frame
	void Update()
	{
			
	}
}

