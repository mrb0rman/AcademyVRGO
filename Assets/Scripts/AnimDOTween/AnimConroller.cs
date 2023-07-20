using DG.Tweening;
using UnityEngine;

namespace AnimDOTween
{
    public class AnimConroller
    {
        private AnimPoint _animPoint;
        private Transform _cube;

        public AnimConroller(Transform cube)
        {
            _cube = cube;
        }

        public void StartAnim()
        {
            _animPoint.Tween.Kill();
            _cube.DOMove(_animPoint.EndPosition, _animPoint.TimeMove).SetEase(_animPoint.EasePosition);
            _cube.DOScale(_animPoint.EndScale, _animPoint.TimeScale).SetEase(_animPoint.EaseScale);
        }

    }
}