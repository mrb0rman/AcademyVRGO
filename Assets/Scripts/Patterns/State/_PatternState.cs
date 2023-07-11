using UnityEngine;


namespace Script
{
    public class _PatternState : MonoBehaviour
    {
        private Water water;
        void Start()
        {
            water = new Water(new FirstState());
            water.Frost();
            water.Frost();
            water.Frost();
            water.Heat();
            water.Heat();
            water.Heat();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}


