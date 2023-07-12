using UnityEngine;

namespace Script.Game
{
    public class CommandUp : IPlayerCommand
    {
        private GameObject _gameObject;

        public CommandUp(GameObject gameObject)
        {
            _gameObject = gameObject;
        }
        public void Execute()
        {
            _gameObject.transform.position += new Vector3(0,0,1);
        }

        public void ExecuteUndo()
        {
            _gameObject.transform.position += new Vector3(0,0,-1);
        }
    }
}