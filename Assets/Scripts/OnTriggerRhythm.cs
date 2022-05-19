using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerRhythm : MonoBehaviour
{
    private bool withinTrigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            if (withinTrigger)
            {
                Debug.Log("Hit");
            }
            else
            {
                Debug.Log("Miss");

            }
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        withinTrigger = true;
    }

    void OnTriggerExit(Collider other)
    {
        withinTrigger = false;
    }
}
