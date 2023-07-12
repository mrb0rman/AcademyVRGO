using System;
using UnityEngine;

namespace Script
{
    public class FirstState : IState
    {
        public void Down(Object_ @object)
        {
            Debug.Log("Переход в состояние 2");
            @object.state = new SecondState(); 
        }

        public void Up(Object_ @object)
        {
            Debug.Log("Состояние 1");
        }
    }

}
