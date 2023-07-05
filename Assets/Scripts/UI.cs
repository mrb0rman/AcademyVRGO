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

        private void Start()
        {
            _window = new UIStartWindow(image);
        }
        private void Update()
        {
            _window.Show(image, speed);
        }
    }
}