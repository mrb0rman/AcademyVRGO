using System;
using System.Collections.Generic;
using UnityEngine;

namespace Script
{

    public abstract class Window : MonoBehaviour, IWindow
    {
        private Dictionary<Type, GameObject> dict;

        public void Load(Type type)
        {
            Debug.Log("Load");
        }
        public void Init()
        {
            dict.Add();
            Debug.Log("Init");
            Debug.Log(dict);
        }
        public void Show<T>() where T : IWindow
        {
            gameObject.SetActive(true);
        }
        public void Hide<T>() where T : IWindow
        {
            gameObject.SetActive(false);
            
        }

        public void Get<T>(string name) where T : IWindow
        {
        }
    }
}