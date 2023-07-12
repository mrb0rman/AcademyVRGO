using System;
using UnityEngine;

namespace Script
{
    public class ThirdState : IState
    {
        public void Down(Object_ @object)
        {
            Debug.Log("Состояние 3");
        }

        public void Up(Object_ @object)
        {
            Debug.Log("Переход в состояние 2");
            @object.state = new SecondState();
        }
    }

}
