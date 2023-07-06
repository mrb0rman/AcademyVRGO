using UnityEngine;

namespace Script
{
    public class MenuController : MonoBehaviour
    {
        public GameObject activePanel;
        public GameObject loadPanel;
        
        private void Start()
        {
            Debug.Log("Start");
            var windows = Resources.LoadAll<GameObject>("");
            foreach (var w in windows)
            {
                Debug.Log(w);
            }
        }

        private void Update()
        {
            
        }
    }
}