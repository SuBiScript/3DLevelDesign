using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debugModeTeleport : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform initPos;
    public Transform checkpoint1;
    public Transform checkpoint2;
    public Transform checkpoint3;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            transform.position = initPos.position;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            transform.position = checkpoint1.position;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            transform.position = checkpoint2.position;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            transform.position = checkpoint3.position;
        }
    }
}
