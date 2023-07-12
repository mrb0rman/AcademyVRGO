using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Script.Game
{
    public class PlayerControll : MonoBehaviour
    {
        private Invoker invokerPlayer = new Invoker();
        public Text text;
        private Observable observable = new Observable();
        // Use this for initialization
        void Start()
        {
            observable.AddObserver(new EndGameObserver());
        }

        // Update is called once per frame
        void Update()
        {
            InputGetKeyDown();
            text.text = "Step " + invokerPlayer.sCommand.Count;
            if(invokerPlayer.sCommand.Count >= 10)
            {
                
            }
        }

        private void InputGetKeyDown()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                invokerPlayer.Execute(new CommandUp(gameObject));
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                invokerPlayer.Execute(new CommandDown(gameObject));
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                invokerPlayer.Execute(new CommandRight(gameObject));
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                invokerPlayer.Execute(new CommandLeft(gameObject));
            }
            else if (Input.GetKeyDown(KeyCode.U))
            {
                invokerPlayer.Undo();
            }
        }
    }
}

