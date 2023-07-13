using System.Collections;
using System.Collections.Generic;
using Script.Game;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Player target;
    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<Player>();
        gameObject.transform.Rotate(new Vector3(30,0,0));
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = target.transform.position + new Vector3(0,4,-7);
    }
}
