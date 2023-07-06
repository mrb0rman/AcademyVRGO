using System;
using UnityEngine;
using UnityEngine.UI;

namespace Script
{
    public class MenuController : MonoBehaviour
    {
        public GameObject ActivePanel;
        public GameObject LoadPanel;

        private void Start()
        {
            var window = Resources.LoadAll<Window>("");
        }
    }
}