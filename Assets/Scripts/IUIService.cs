namespace Script
{
    public interface IUIService
    {
        void Load();
        void Init(UIROOT ui);
        public T Get<T>() where T : UIWindow;
        public void Hide<T>(UIROOT ui) where T : UIWindow;
        public void Show<T>(UIROOT ui) where T : UIWindow;

    }
}