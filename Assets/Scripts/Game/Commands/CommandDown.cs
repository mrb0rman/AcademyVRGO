using UnityEngine;

namespace Script.Game
{
    public class CommandDown : IPlayerCommand
    {
        private GameObject _gameObject;

        public CommandDown(GameObject gameObject)
        {
            _gameObject = gameObject;
        }
        public void Execute()
        {
            _gameObject.transform.position += new Vector3(0,0,-1);
        }

        public void ExecuteUndo()
        {
            _gameObject.transform.position += new Vector3(0,0,1);
        }
    }
}