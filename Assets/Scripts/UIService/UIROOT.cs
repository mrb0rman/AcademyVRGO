using UnityEngine;
using UnityEngine.Serialization;

namespace Script
{
    public class UIROOT : MonoBehaviour, IUIROOT
    {
        [SerializeField] private Transform activateConteiner;
        [SerializeField] private Transform deactivateConteiner;
        
        public Transform ActivateConteiner { get => activateConteiner; }
        public Transform DeactivateConteiner { get => deactivateConteiner; }
    }
}