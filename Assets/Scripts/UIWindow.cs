using UnityEngine;

namespace Script
{
    public abstract class UIWindow : MonoBehaviour, IUIWindow
    {
        public virtual void Hide()
        {
            gameObject.SetActive(true);
        }

        public virtual void Show()
        {
            
        }
    }
}