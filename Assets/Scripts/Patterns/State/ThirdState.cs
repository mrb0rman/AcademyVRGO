using System;
using UnityEngine;

namespace Script
{
    public class ThirdState : IState
    {
        public void Frost(Water water)
        {
            Debug.Log("Охлаждаем лед");
        }

        public void Heat(Water water)
        {
            Debug.Log("Плавим лед");
            water.state = new SecondState();
        }
    }

}
