﻿using System;
using UnityEngine;

namespace Script
{
    public class CommandForward : ICommand
    {
        public void Execute()
        {
            Debug.Log("+5 к X");
        }

        public void ExecuteUndo()
        {
            Debug.Log("-5 к X");
        }
        
    }
}




