using System;
using UnityEngine;

namespace Script
{
    public class FirstState : IState
    {
        public void Frost(Water water)
        {
            Debug.Log("Охлаждаем пар");
            water.state = new SecondState(); 
        }

        public void Heat(Water water)
        {
            Debug.Log("Нагреваем пар");
        }
    }

}
