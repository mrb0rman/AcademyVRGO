namespace Script
{
    public interface IWindow
    {
        void Load();
        void Init();
        void Show<T>();
        void Hide<T>();
    }
}