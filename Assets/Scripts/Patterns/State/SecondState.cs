using System;
using UnityEngine;

namespace Script
{
    public class SecondState : IState
    {
        public void Down(Object_ @object)
        {
            Debug.Log("Переход в состояние 3");
            @object.state = new ThirdState();
        }

        public void Up(Object_ @object)
        {
            Debug.Log("Переход в состояние 1");
            @object.state = new FirstState();
        }
    }

}
