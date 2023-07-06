using System;
using System.Collections.Generic;
using UnityEngine;

namespace Script
{
    public class MenuController : MonoBehaviour
    {
        public GameObject activePanel;
        public GameObject loadPanel;
        private Dictionary<Type, GameObject[]> dict = new Dictionary<Type, GameObject[]>();

        [SerializeField] UIROOT _ui;

        private void Start()
        {
            var windows = Resources.LoadAll<GameObject>("");

            dict.Add(windows[0].GetType(), windows);
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                Debug.Log("1");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                Debug.Log("2");
            } else if(Input.GetKeyDown(KeyCode.Alpha3))
            {
                Debug.Log("3");
            }
        }
    }
}