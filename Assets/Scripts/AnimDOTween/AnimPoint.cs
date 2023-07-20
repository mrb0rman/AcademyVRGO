using System;
using DG.Tweening;
using UnityEngine;

namespace AnimDOTween
{
    [Serializable]
    public class AnimPoint
    {
        public Tween Tween;
        public Ease EasePosition;
        public Ease EaseScale;
        public Ease EaseRotation;
        public Vector3 EndPosition;
        public Vector3 EndScale;
        public Quaternion EndRotation;
        public float TimeMove;
        public float TimeScale;
        public float TimeRotation;
        
    }
}