using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace Script
{
    public class AnimatorDOTween : MonoBehaviour
    {
        private Vector3 _startPosition;
        private Vector3 _startScale;
        private Vector3 _startRotate;
        private AnimConroller _animConroller;
        public Transform cube;
        public AnimPoint[] listAnimPoint;


        private void Start()
        {
            
            _animConroller = new AnimConroller(cube);
            _animConroller.Init(listAnimPoint);
            _startPosition = cube.position;
            _startScale = cube.localScale;
            _startRotate = cube.eulerAngles;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                ReturnToStartParameters();
                Anim1();
            }
            else if(Input.GetKeyDown(KeyCode.Alpha2))
            {
                _animConroller.SequenceKill();
                ReturnToStartParameters();
                _animConroller.PlayAnimOne();
                
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                _animConroller.SequenceKill();
                ReturnToStartParameters();
                _animConroller.PlayAnimTwo();
            }
            else if(Input.GetKeyDown(KeyCode.R))
            {
                _animConroller.SequenceKill();
                ReturnToStartParameters(); 
            }


        }
 
        public void ReturnToStartParameters()
        {
            cube.position = _startPosition;
            cube.localScale = _startScale;
            cube.eulerAngles = _startRotate;
        }

        public void Anim1()
        {
            cube.DOMove(new Vector3(20,1,0), 4f).SetEase(Ease.InBounce);
        }
    }
}