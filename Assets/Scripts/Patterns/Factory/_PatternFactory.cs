using UnityEngine;

namespace Script
{
    public class _PatternFactory : MonoBehaviour
    {
        // Use this for initialization
        void Start()
        {
            Factory factory = new FactoryFirst();
            Product product = factory.Create();
            factory = new FactorySecond();
            Product product1 = factory.Create();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}


