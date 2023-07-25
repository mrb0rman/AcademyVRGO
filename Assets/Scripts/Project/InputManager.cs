using UnityEngine;
using UnityEngine.UI;

namespace Script.Project
{
    public class InputManager : MonoBehaviour
    {
        
        private Vector3 offset;
        private Invoker _invoker = new Invoker();
        private PlayerConroller playerConroller;
        public GameObject mainCamera;
        public float speed;
        public Text text;
        public StateMachine movementSM;
        public Player player;
        public IdleStateSpell waiting;
        // Use this for initialization


        void Start()
        {
            player.mp = 100f;
            player.maxMp = 100f;
            playerConroller = new PlayerConroller(player);
            offset = mainCamera.transform.position + new Vector3(0, 1, 0);
            movementSM = new StateMachine();
            waiting = new IdleStateSpell();
            movementSM.Initialize(waiting, playerConroller, _invoker, movementSM);
            playerConroller.Change += UIMp;
            text.text = $"{player.mp}";
        }

        // Update is called once per frame
        void Update()
        {
            PlayerMove();
            movementSM.CurrentState.HandleInput();
            movementSM.CurrentState.LogicUpdate();
        }

        public void PlayerMove()
        {
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(x, 0, z);
            player.transform.Translate(movement * speed * Time.deltaTime);
            mainCamera.transform.position = player.transform.position + offset;
            mainCamera.transform.LookAt(player.transform); 
        }
        public void UIMp()
        {
            text.text = $"{player.mp}";
        }
    }
}


