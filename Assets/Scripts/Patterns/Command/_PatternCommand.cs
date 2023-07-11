using UnityEngine;
using System.Collections;

namespace Script
{
    public class _PatternCommand : MonoBehaviour
    {
        private Invoker invoker = new Invoker();
        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.U))
            {
                invoker.Undo();
            } else if(Input.GetKeyDown(KeyCode.W))
            {
                invoker.Execute(new CommandForward());
            } else if (Input.GetKeyDown(KeyCode.D))
            {
                invoker.Execute(new CommandLeft());
            }
        }
    }
}


