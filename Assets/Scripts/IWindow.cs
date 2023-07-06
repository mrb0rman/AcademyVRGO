using System;

namespace Script
{
    public interface IWindow
    {
        void Load(); 
        void Init();
        void Show<T>(UIROOT _ui) where T : Window;
        void Hide<T>(UIROOT _ui) where T : Window;
        void Get<T>() where T : Window;
    }
}