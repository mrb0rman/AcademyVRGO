using System;
using DG.Tweening;
using UnityEngine;

namespace Script
{
    [Serializable]
    public class AnimPoint
    {
        public bool isMoving;
        public Ease EasePosition;
        public Vector3 EndPosition;
        public float TimeMove;

        public bool isScale;
        public Ease EaseScale;
        public Vector3 EndScale;
        public float TimeScale;

        public bool isRotate;
        public Ease EaseRotation;
        public Vector3 EndRotation;
        public float TimeRotation;
        
    }
}