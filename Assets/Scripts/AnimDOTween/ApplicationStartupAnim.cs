using System;
using Script.Game;
using UnityEngine;

namespace Script
{
    public class ApplicationStartupAnim : MonoBehaviour
    {
        public Camera camera;
        private void Start()
        {
            camera = Instantiate(Resources.Load<Camera>("Main Camera"));
            Light directionalLight = Instantiate(Resources.Load<Light>("Directional Light"));
        }
    }
}