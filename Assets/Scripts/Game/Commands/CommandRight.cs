using UnityEngine;

namespace Script.Game
{
    public class CommandRight : IPlayerCommand
    {
        private GameObject _gameObject;

        public CommandRight(GameObject gameObject)
        {
            _gameObject = gameObject;
        }
        public void Execute()
        {
            _gameObject.transform.position += new Vector3(-1,0,0);
        }

        public void ExecuteUndo()
        {
            _gameObject.transform.position += new Vector3(1,0,0);
        }
    }
}