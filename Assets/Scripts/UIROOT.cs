﻿using UnityEngine;

namespace Script
{
    public class UIROOT : MonoBehaviour, IUIROOT
    {
        [SerializeField] private Transform conteiner;
        [SerializeField] private Transform deactivateConteiner;
        
        public Transform Conteiner { get => conteiner; }
        public Transform DeactivateConteiner { get => deactivateConteiner; }
    }
}