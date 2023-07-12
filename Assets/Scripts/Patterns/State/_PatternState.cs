using UnityEngine;


namespace Script
{
    public class _PatternState : MonoBehaviour
    {
        private Object_ _object;
        void Start()
        {
            _object = new Object_(new FirstState());
            _object.Down();
            _object.Down();
            _object.Down();
            _object.Up();
            _object.Up();
            _object.Up();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}


