namespace Script
{
    public interface IObjectState
    {
        public void On(ObjectGame _gameObject);
        public void Off(ObjectGame _gameObject);
    }
}