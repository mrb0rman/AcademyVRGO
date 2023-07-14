using UnityEngine;

namespace Script.Game
{
    public class CommandLeft : IPlayerCommand
    {
        private Player _gameObject;

        public CommandLeft(Player gameObject)
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