﻿using UnityEngine;

namespace Script
{
    public class CommandUp : ICubeCommand
    {
        private GameObject _gameObject;

        public CommandUp(GameObject gameObject)
        {
            _gameObject = gameObject;
        }
        public void Execute()
        {
            _gameObject.transform.position += new Vector3(0,1,0);
        }

        public void ExecuteUndo()
        {
            _gameObject.transform.position += new Vector3(0,-1,0);
        }
    }
}