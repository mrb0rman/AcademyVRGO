using UnityEngine;
using System.Collections;

namespace Script.Project
{
    public class InputManager : MonoBehaviour
    {
        private Player player;
        private Vector3 offset;
        private ISpellCommand spellCommand;
        private Invoker invoker = new Invoker();        

        public GameObject mainCamera;
        public float speed;
        // Use this for initialization
        void Start()
        {
            Instantiate((GameObject)Resources.Load("level"), new Vector3(0, 0, 0), Quaternion.identity);
            player = Instantiate(Resources.Load<Player>("Player"), new Vector3(0, 1, 0), Quaternion.identity);
            offset = mainCamera.transform.position + new Vector3(0, 1, 0);
            
        }

        // Update is called once per frame
        void Update()
        {
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(x, 0, z);
            player.transform.Translate(movement * speed * Time.deltaTime);
            mainCamera.transform.position = player.transform.position + offset;
            mainCamera.transform.LookAt(player.transform);

            if(Input.GetKeyDown(KeyCode.F) && invoker.sCommand.Count < 5)
            {
                spellCommand = new CreateSpell(SpellType.Fire, player);
                invoker.Execute(spellCommand);
            } else if(Input.GetKeyDown(KeyCode.U))
            {
                invoker.Undo();
            }
        }
    }
}


