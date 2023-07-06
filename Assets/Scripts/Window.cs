using System;
using System.Collections.Generic;
using UnityEngine;

namespace Script
{

    public abstract class Window : MonoBehaviour, IWindow
    {
        private Dictionary<Type, GameObject> dict;

        public void Load()
        {
            
            
            Debug.Log("Load");
        }
        public void Init()
        {
            
        }
        public void Show<T>(UIROOT _ui) where T : Window
        {
            gameObject.transform.SetParent(_ui.Conteiner);
        }
        public void Hide<T>(UIROOT _ui) where T : Window
        {
            gameObject.transform.SetParent(_ui.DeactivateConteiner);
        }

        public void Get<T>() where T : Window
        {

        }
    }
}