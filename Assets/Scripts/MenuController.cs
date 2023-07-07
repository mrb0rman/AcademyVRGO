﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace Script
{
    public class MenuController : MonoBehaviour
    {
        /*public GameObject activePanel;
        public GameObject loadPanel;*/

        [SerializeField] UIROOT _ui;
        private UIService _uiService = new UIService();
        private void Start()
        {
            _uiService.Load();
            _uiService.Init(_ui);
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                _uiService.Show<StartUIWindow>(_ui);
                Debug.Log("1");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                // _uiService.Get<StartUIWindow>().Hide();
                _uiService.Hide<StartUIWindow>(_ui);
                Debug.Log("2");
            } else if(Input.GetKeyDown(KeyCode.Alpha3))
            {
                Debug.Log("3");
            }
        }
    }
}