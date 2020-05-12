using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeManager : MonoBehaviour
{
    // Start is called before the first frame update

    bool isTimeSlowed = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (!isTimeSlowed)
            {
                Time.timeScale = 0;
                isTimeSlowed = true;
            }
            else
            {
                Time.timeScale = 1;
                isTimeSlowed = false;
            }
        }
    }
}
