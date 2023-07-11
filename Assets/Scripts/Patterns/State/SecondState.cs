using System;
using UnityEngine;

namespace Script
{
    public class SecondState : IState
    {
        public void Frost(Water water)
        {
            Debug.Log("Замораживаем воду");
            water.state = new ThirdState();
        }

        public void Heat(Water water)
        {
            Debug.Log("Нагреваем воду");
            water.state = new FirstState();
        }
    }

}
