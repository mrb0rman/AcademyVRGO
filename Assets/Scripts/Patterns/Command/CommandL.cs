﻿using System;
using UnityEngine;

namespace Script
{
    public class CommandL : ICommand
    {
        public void Execute()
        {
            Debug.Log("+5 к Y");
        }

        public void ExecuteUndo()
        {
            Debug.Log("-5 к Y");
        }

    }
}




