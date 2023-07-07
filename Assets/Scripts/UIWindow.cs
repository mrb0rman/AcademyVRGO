using UnityEngine;

namespace Script
{
    public abstract class UIWindow : MonoBehaviour, IUIWindow
    {
        public virtual void Hide()
        {
            gameObject.SetActive(false);
        }

        public virtual void Show()
        {
            gameObject.SetActive(true);
        }
    }
}