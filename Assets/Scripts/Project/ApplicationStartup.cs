using System;
using UnityEngine;

namespace Script.Project
{
    public class ApplicationStartup : MonoBehaviour
    {
        public InputManager _inputManager;
        public GameObject mainCamera;
        public Light directionLight;
        public GameObject level;
        public ScoreMP scoreMp;
        public Player player;

        private void Start()
        {
            var mC = Instantiate(mainCamera, new Vector3(0,20,0), Quaternion.identity);
            var pl = Instantiate(player, new Vector3(0,1,0), Quaternion.identity);
            Instantiate(directionLight);
            Instantiate(scoreMp.gameObject);
            Instantiate(level);
            var iM = Instantiate(_inputManager);
            iM.text = scoreMp.Text;
            iM.mainCamera = mC;
            iM.player = pl;
            Instantiate(Resources.Load("EventSystem"));
            Destroy(this.gameObject);
        }
    }
}