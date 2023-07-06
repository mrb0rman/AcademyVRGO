using UnityEngine;

namespace Script
{

    public abstract class Window : MonoBehaviour, IWindow
    {
        public void Load()
        {
            
        }
        public void Init()
        {
            
        }
        public void Show<T>()
        {
            gameObject.SetActive(true);
        }
        public void Hide<T>()
        {
            gameObject.SetActive(false);
            
        }
    }
}