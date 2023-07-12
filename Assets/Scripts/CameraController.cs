using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.Rotate(new Vector3(30,0,0));
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = target.transform.position + new Vector3(0,4,-7);
    }
}
