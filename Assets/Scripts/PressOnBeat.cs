using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressOnBeat : MonoBehaviour
{
    public bool boolTest;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        Conductor.instance.hit += test;
        Conductor.instance.notYet += test2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void test()
    {
        boolTest = true;
    }

    void test2()
    {
        boolTest = false;
    }
}
