using System;
using UnityEngine;
using UnityEngine.UI;


namespace Script.UI
{
    public class UI : MonoBehaviour
    {
        public UIStartWindow _window;
        public Image image;
        public float speed;
        private bool isPressed = false;

        private void Start()
        {
            _window = new UIStartWindow(image);
        }
        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.A) && !isPressed)
            {
                isPressed = true;
            }
            else if(isPressed)
            {
                _window.Show(image, speed);
            }
        }
    }
}