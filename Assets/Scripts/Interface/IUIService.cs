using System;

namespace Script
{
    public interface IUIService
    {
        void Load();
        void Init(UIROOT ui);
        public T Get<T>() where T : UIWindow;
        public Type Hide<T>() where T : UIWindow;
        public Type Show<T>() where T : UIWindow;

    }
}