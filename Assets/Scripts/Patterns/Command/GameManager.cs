using UnityEngine;
using System.Collections;

namespace Script
{
    public class GameManager : MonoBehaviour
    {
        Invoker invoker = new Invoker();
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
            }
        }
    }
}


