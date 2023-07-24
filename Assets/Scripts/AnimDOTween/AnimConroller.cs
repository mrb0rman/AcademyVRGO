using DG.Tweening;
using UnityEngine;

namespace Script
{
    public class AnimConroller
    {
        private AnimPoint[] _animPoints;
        private Transform _cube;
        public Sequence sequence { get; private set; }

        public AnimConroller(Transform cube)
        {
            _cube = cube; 
        }

        public void Init(AnimPoint[] animPoints)
        {
            _animPoints = animPoints;
        }

        public void PlayAnimOne()
        {
            sequence = DOTween.Sequence();
            foreach (var animPoint in _animPoints)
            {
                if (animPoint.isMoving)
                    sequence.Append(_cube.DOMove(animPoint.EndPosition, animPoint.TimeMove).SetEase(animPoint.EasePosition));
                if (animPoint.isScale)
                    sequence.Append(_cube.DOScale(animPoint.EndScale, animPoint.TimeScale).SetEase(animPoint.EaseScale));
                if (animPoint.isRotate)
                    sequence.Append(_cube.DORotate(animPoint.EndRotation, animPoint.TimeRotation).SetEase(animPoint.EaseRotation));
            }
        }

        public void PlayAnimTwo()
        {
            sequence = DOTween.Sequence();
            sequence.Append(_cube.DOJump(new Vector3(18f, 10f, -4f), 2f, 10, 5f));
            sequence.Insert(0f, _cube.DOScale(5f, 5f));
            sequence.Insert(0f, _cube.gameObject.GetComponent<Renderer>().material.DOColor(Color.red, 5f));
            sequence.Append(_cube.DOMove(new Vector3(-18f, 10f, -4f), 5f).SetEase(Ease.InOutElastic));
            sequence.Insert(5f, _cube.DOScale(2f, 5f).SetEase(Ease.InOutFlash));
            sequence.Append(_cube.DOMove(new Vector3(-18f, 1f, -4f), 3f));
            sequence.Insert(10f, _cube.gameObject.GetComponent<Renderer>().material.DOColor(Color.white, 5f));
            sequence.Insert(10f, _cube.DOScale(2f, 5f).SetEase(Ease.OutSine))
                .SetLoops(4);
        }

        public void SequenceKill()
        {
            sequence?.Kill();
        }
    }
}