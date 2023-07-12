using UnityEngine;

namespace Script
{
    public class Mono : MonoBehaviour
    {
        private InvokerCube invokerCube = new InvokerCube();
        public GameObject gameObject;
        private ObjectGame cube;
        private bool isActive = true;
        private void Start()
        {
            cube = new Cube(gameObject, new Visible());
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                invokerCube.Execute(new CommandUp(gameObject));
            }else if (Input.GetKeyDown(KeyCode.S))
            {
                invokerCube.Execute(new CommandDown(gameObject));
            }else if (Input.GetKeyDown(KeyCode.A))
            {
                invokerCube.Execute(new CommandRight(gameObject));
            }else if (Input.GetKeyDown(KeyCode.D))
            {
                invokerCube.Execute(new CommandLeft(gameObject));
            }else if (Input.GetKeyDown(KeyCode.U))
            {
                invokerCube.Undo();
            }else if (Input.GetKeyDown(KeyCode.V))
            {
                if (isActive)
                {
                    cube.Off();
                    isActive = false;
                }
                else
                {
                    cube.On();
                    isActive = true;
                }
            }
        }
    }
}