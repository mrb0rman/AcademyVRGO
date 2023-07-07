

// TODO:
// Дописать в hide и show проверки на null и сделать обнуление координат


using System;
using System.Collections.Generic;
using UnityEngine;

namespace Script
{
    public class UIService : IUIService
    {
        private Dictionary<Type, UIWindow> loadedWindows = new Dictionary<Type, UIWindow>();
        private Dictionary<Type, GameObject> initWindows = new Dictionary<Type, GameObject>();
        
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
            foreach (var key in loadedWindows.Keys)
            {
                UIWindow view =  GameObject.Instantiate(loadedWindows[key], ui.DeactivateConteiner);
                initWindows.Add(key, view.gameObject);
            }
        }

        public T Get<T>() where T : UIWindow
        {
            var type = typeof(T);
            return initWindows[type]?.GetComponent<T>() ?? null;
            
        }

        public void Hide<T>(UIROOT ui) where T : UIWindow
        {
            var type = typeof(T);
            GameObject window = initWindows[type];
            if (initWindows.ContainsKey(type))
            {
                window.transform.SetParent(ui.DeactivateConteiner, false);
                window.transform.position = ui.ActivateConteiner.transform.position;
                window.transform.rotation = ui.ActivateConteiner.transform.rotation;
                window.transform.localScale = ui.ActivateConteiner.transform.localScale;
            }
        }

        public void Show<T>(UIROOT ui) where T : UIWindow
        {
            var type = typeof(T);
            GameObject window = initWindows[type];
            if (initWindows.ContainsKey(type))
            {
                window.transform.position = ui.ActivateConteiner.transform.position;
                window.transform.rotation = ui.ActivateConteiner.transform.rotation;
                window.transform.localScale = ui.ActivateConteiner.transform.localScale;
                window.transform.SetParent(ui.ActivateConteiner, false);
            }
        }
    }
}