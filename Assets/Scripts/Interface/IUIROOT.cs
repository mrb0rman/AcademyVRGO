using UnityEngine;

namespace Script
{
    public interface IUIROOT
    {
        Transform ActivateConteiner { get; }
        Transform DeactivateConteiner { get; }
    }
}