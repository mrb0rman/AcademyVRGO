using UnityEngine;

namespace Script
{
    public class Cube : ObjectGame
    {
        private GameObject _gameObject;
        public Cube(GameObject gameObject, IObjectState startState)
        {
            state = startState;
            _gameObject = gameObject;
        }
        public override void On()
        {
            state.On(this);
            _gameObject.SetActive(true);
        }
        public override void Off()
        {
            state.Off(this);
            _gameObject.SetActive(false);
        }
    }
}