using UnityEngine;

namespace Script.Game
{
    public class CommandLeft : IPlayerCommand
    {
        private GameObject _gameObject;

        public CommandLeft(GameObject gameObject)
        {
            _gameObject = gameObject;
        }
        public void Execute()
        {
            _gameObject.transform.position += new Vector3(1,0,0);
        }

        public void ExecuteUndo()
        {
            _gameObject.transform.position += new Vector3(-1,0,0);
        }
    }
}