using System;

namespace Script
{
    public interface IWindow
    {
        void Load(Type type); 
        void Init(Window window, string name);
        void Show<T>() where T : IWindow;
        void Hide<T>() where T : IWindow;
        void Get<T>(string name) where T : IWindow;
    }
}