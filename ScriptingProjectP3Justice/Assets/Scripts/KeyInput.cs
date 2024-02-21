using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInput: MonoBehaviour
{
    public Text boolDisplay1;
    public Text boolDisplay2;
    public Text boolDisplay3;

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKeyUp(KeyCode.Space);
        
        if (down) { 
        }

        boolDisplay1.text = " " + down;
        boolDisplay2.text = " " + held;
        boolDisplay3.text = " " + up;
    }
}
