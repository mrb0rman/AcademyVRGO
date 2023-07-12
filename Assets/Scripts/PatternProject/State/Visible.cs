namespace Script
{
    public class Visible : IObjectState
    {
        public void On(ObjectGame _gameObject)
        {
        }
        public void Off(ObjectGame _gameObject)
        {
            _gameObject.state = new UnVisible();
        }
    }
}