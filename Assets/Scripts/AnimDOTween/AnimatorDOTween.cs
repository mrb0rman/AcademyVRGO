using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace AnimDOTween
{
    public class AnimatorDOTween : MonoBehaviour
    {
        private Vector3 _startPosition;
        private Vector3 _startScale;
        private AnimConroller _animConroller;
        public Transform cube;
        public List<AnimPoint> listAnimPoint  = new List<AnimPoint>();


        private void Start()
        {
            
            _animConroller = new AnimConroller(cube);
            _startPosition = cube.position;
            _startScale = cube.localScale;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Anim1();
            }
            else if(Input.GetKeyDown(KeyCode.Alpha2))
            {
                //ReturnToStartParameters();
                var seq = DOTween.Sequence();
                foreach (var animPoint in listAnimPoint)
                {
                    seq.Append(cube.DOMove(animPoint.EndPosition, animPoint.TimeMove).SetEase(animPoint.EasePosition)); 
                }
            }

        }
 
        public void ReturnToStartParameters()
        {
            cube.position = _startPosition;
            cube.localScale = _startScale;
        }

        public void KillAllTween()
        {
            foreach (var animPoint in listAnimPoint)
            {
                animPoint.Tween.Kill();
            }
        }

        public void Anim1()
        {
            cube.DOMove(new Vector3(20,1,0), 4f).SetEase(Ease.InBounce);
        }
    }
}