using UnityEngine;
using System.Collections;
using UnityEditor;
using UnityEngine.UI;

namespace Script.Game
{
    public class PlayerControll : MonoBehaviour
    {
        private Invoker invokerPlayer = new Invoker();
        public Text text;
        private GameObject player;

        private FactoryPrimitiveCube _factoryPrimitive = new FactoryPrimitiveCube();
        // Use this for initialization
        void Start()
        {
            player = _factoryPrimitive.Create(PrimitiveForm.Cylinder);
        }

        // Update is called once per frame
        void Update()
        {
            InputGetKeyDown();
            text.text = "Step " + invokerPlayer.sCommand.Count;
        }

        private void InputGetKeyDown()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                invokerPlayer.Execute(new CommandUp(player));
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                invokerPlayer.Execute(new CommandDown(player));
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                invokerPlayer.Execute(new CommandRight(player));
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                invokerPlayer.Execute(new CommandLeft(player));
            }
            else if (Input.GetKeyDown(KeyCode.U))
            {
                invokerPlayer.Undo();
            }
        }
    }
}

