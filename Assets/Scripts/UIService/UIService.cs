using System;
using System.Collections.Generic;
using UnityEngine;

namespace Script
{
    public class UIService : IUIService
    {
        private Dictionary<Type, UIWindow> loadedWindows = new Dictionary<Type, UIWindow>();
        private Dictionary<Type, GameObject> initWindows = new Dictionary<Type, GameObject>();
        private UIROOT ui;
            
        public void Load()
        {
            var windows = Resources.LoadAll("", typeof(UIWindow));
            foreach (var window in windows)
            {
                var type = window.GetType();
                loadedWindows.Add(type, (UIWindow) window);
            }
        }
        
        public void Init(UIROOT ui)
        {
            GameObject.Instantiate(Resources.Load("EventSystem"));
            this.ui = ui;
            foreach (var key in loadedWindows.Keys)
            {
                UIWindow view =  GameObject.Instantiate(loadedWindows[key], ui.DeactivateConteiner);
                initWindows.Add(key, view.gameObject);
            }
        }

        public T Get<T>() where T : UIWindow
        {
            var type = typeof(T);
            if(initWindows.ContainsKey(type))
            {
                return initWindows[type].GetComponent<T>();
            }
            return null;
            
        }

        public Type Hide<T>() where T : UIWindow
        {
            var type = typeof(T);
            if (initWindows.ContainsKey(type))
            {
                var rect = initWindows[type].transform as RectTransform;
                Update(rect);
                rect.SetParent(ui.DeactivateConteiner, false);
            }
            return type;
        }

        public Type Show<T>() where T : UIWindow
        {
            var type = typeof(T);
            if (initWindows.ContainsKey(type))
            { 
                var rect = initWindows[type].transform as RectTransform;
                Update(rect);
                rect.SetParent(ui.ActivateConteiner, false);
            }
            return type;
        }

        private void Update(RectTransform rect)
        {
            rect.localPosition = ui.ActivateConteiner.transform.position;
            rect.localRotation = ui.ActivateConteiner.transform.rotation;
            rect.localScale = ui.ActivateConteiner.transform.localScale;
            rect.offsetMin = Vector2.zero;
            rect.offsetMax = Vector2.zero;
        }
    }
}
