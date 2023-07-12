namespace Script
{
    public class UnVisible : IObjectState
    {
        public void On(ObjectGame _gameObject)
        {
            _gameObject.state = new Visible();
        }
        public void Off(ObjectGame _gameObject)
        {
        }
    }
}